using Guna.UI.WinForms;
using Personnel.connexion;
using Personnel.interfaces;
using Personnel.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel.controlleur
{
     class Controleur : Interface1
    {
        Connexion cnx = null;
        private static Controleur co;
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter dt = null;
        SqlDataReader dr = null;
        public int id = 0;
        public void initConnect()
        {
            try
            {
                cnx = new Connexion();
                cnx.connect();
                con = new SqlConnection(cnx.chemin);
            }
            catch (Exception)
            {
                throw new Exception("l'un de vos fichiers de configuration est incorrect");
            }
            finally
            {
                con.Close();
            }

        }
        public static Controleur GetInstance()
        {
            if (co == null)
                co = new Controleur();
            return co;
        }
       
        public void appel(Panel p, UserControl u)
        {
            p.Controls.Clear();
            p.Controls.Add(u);
            p.Show();

        }
        public void openPhoto(PictureBox p)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.InitialDirectory = "C:\\Images";
            f.Filter = "jpeg|*.jpeg|png|*.png|jpg|*.jpg|tous les fichierss|*.*";
            //  f.ShowDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                p.Image = Image.FromFile(f.FileName);
            }
        }
       // #region 
        public void supprimer(int code, String table, string col, DataGridView d, string sql)
        {
            try
            {

                if (id > 0)
                {
                    DialogResult res = MessageBox.Show("Voulez-vous supprimer ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        con.Open();
                        cmd = new SqlCommand("delete from " + table + " where " + col + "= @id", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        chargement(sql, d);
                        MessageBox.Show("Suppression reussie ");
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de suppression " + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void chargeCombo(ComboBox cmb, string nomChamp, string nomTable)
        {
            initConnect();
            if (!con.State.ToString().Trim().ToLower().Equals("open")) con.Open();
            using (IDbCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = @"select distinct " + nomChamp + " from " + nomTable + "";
                IDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string de = rd[nomChamp].ToString();
                    cmb.Items.Add(de);
                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }

        }

        //rechercher dans la table

        public void rechercher(string sql, DataGridView dat)
        {
            try
            {
                initConnect();
                con.Open();
                DataTable tab = new DataTable();
                dt = new SqlDataAdapter(sql, con);
                dt.Fill(tab);
                dat.DataSource = tab;
                con.Close();
            }
            catch(Exception e)
            {

            }
            finally
            {
                con.Close();
            }

        }

        public void chargement(string sql, DataGridView d)
        {
            try
            {
                initConnect();
                SqlCommand com = new SqlCommand("select * from " + sql + "", con);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader dtr = com.ExecuteReader();
                dt.Load(dtr);
                con.Close();
                d.DataSource = dt;
            }
            catch(Exception e)
            {

            }
            finally
            {
                con.Close();
            }

        }
        public void saveAgent(Object o)
        {
            try
            {
                M_Agent ag = (M_Agent)o;
                initConnect();
                con.Open();
                cmd = new SqlCommand("exec p_agent @id,@nom,@post,@prenom,@sexe,@datenaiss,@etat,@nation,@adresse,@tel,@etude,@photo", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", ag.Id);
                cmd.Parameters.AddWithValue("@nom", ag.Nom);
                cmd.Parameters.AddWithValue("@post", ag.Postnom);
                cmd.Parameters.AddWithValue("@prenom", ag.Prenom);
                cmd.Parameters.AddWithValue("@sexe", ag.Sexe);
                cmd.Parameters.AddWithValue("@datenaiss", DateTime.Parse(ag.Date));
                cmd.Parameters.AddWithValue("@etat", ag.Etat);
                cmd.Parameters.AddWithValue("@nation", ag.Nationalite);
                cmd.Parameters.AddWithValue("@adresse", ag.Adresse);
                cmd.Parameters.AddWithValue("@tel", ag.Telephone);
                cmd.Parameters.AddWithValue("@etude", ag.Niveau);
                cmd.Parameters.AddWithValue("@photo", ag.Photo);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cool");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur " + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private byte[] photo(PictureBox pb)
        {
            MemoryStream ms = new MemoryStream();
            pb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] photo = new Byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo, 0, photo.Length);

            return photo;
        }
        public void agent(int code, GunaLineTextBox nom, GunaLineTextBox post, GunaLineTextBox prenom, ComboBox sexe, MaskedTextBox date, ComboBox etat, GunaLineTextBox nation, GunaLineTextBox adresse, MaskedTextBox tel, ComboBox niv, PictureBox pb, string sql, DataGridView t)
        {
            try
            {
                M_Agent a = new M_Agent();

                initConnect();
                a.Id = id;
                a.Nom = nom.Text;
                a.Postnom = post.Text;
                a.Prenom = prenom.Text;
                a.Sexe = sexe.Text;
                DateTime.Parse(a.Date = date.Text);
                a.Etat = etat.Text;
                a.Nationalite = nation.Text;
                a.Adresse = adresse.Text;
                a.Telephone = tel.Text;
                a.Niveau = niv.Text;
                a.Photo = photo(pb);

                saveAgent(a);
                chargement(sql, t);
            }
            catch (Exception e)
            {
                MessageBox.Show("errur" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void deplaceragent(DataGridViewCellEventArgs e, int code, GunaLineTextBox nom, GunaLineTextBox post, GunaLineTextBox prenom, ComboBox sexe, MaskedTextBox date, ComboBox etat, GunaLineTextBox nation, GunaLineTextBox adresse, MaskedTextBox tel, ComboBox niv, PictureBox pb, DataGridView t)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow ro = t.Rows[e.RowIndex];
                id = Convert.ToInt32(ro.Cells[0].Value);
                nom.Text = ro.Cells[1].Value.ToString();
                post.Text = ro.Cells[2].Value.ToString();
                prenom.Text = ro.Cells[3].Value.ToString();
                sexe.Text = ro.Cells[4].Value.ToString();
                etat.Text = ro.Cells[7].Value.ToString();
                nation.Text = ro.Cells[8].Value.ToString();
                adresse.Text = ro.Cells[9].Value.ToString();
                tel.Text = ro.Cells[10].Value.ToString();
                niv.Text = ro.Cells[11].Value.ToString();
                MemoryStream ms = new MemoryStream();
                byte[] photo = (byte[])ro.Cells[12].Value;
                ms.Write(photo, 0, photo.Length);
                pb.Image = new System.Drawing.Bitmap(ms);

           }

        }
        public void service(object o)
        {
            M_Service s = (M_Service)o;
            initConnect();
            try
            {
                con.Open();
                cmd = new SqlCommand("exec p_service @id,@des", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", s.Id);
                cmd.Parameters.AddWithValue("@des", s.Designation);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cool");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur " + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void addService(int code, GunaLineTextBox des, DataGridView d, string sql)
        {
            M_Service serv = new M_Service();
            serv.Id = id;
            serv.Designation = des.Text;
            service(serv);
            chargement(sql, d);
        }

        public void Savefonction(Object o, String mess, string messEr)
        {
            try
            {
                M_Fonction fx = (M_Fonction)o;
                initConnect();
                con.Open();
                cmd = new SqlCommand("exec p_fonction @id,@design,@date,@salaire", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", fx.Id);
                cmd.Parameters.AddWithValue("@design", fx.Designation);
                cmd.Parameters.AddWithValue("@date", fx.Date);
                cmd.Parameters.AddWithValue("@salaire", fx.Salaire);
                cmd.ExecuteNonQuery();
                MessageBox.Show(mess);
            }
            catch (Exception e)
            {
                MessageBox.Show(messEr + e.Message);
            }

            finally
            {
                con.Close();
            }
        }
        public void fonction(int code, GunaLineTextBox l1, GunaDateTimePicker l2, GunaLineTextBox l3, String t, DataGridView d, string m, string mE)
        {
            M_Fonction f = new M_Fonction();
            f.Id = id;
            f.Designation = l1.Text;
            f.Date = DateTime.Parse(l2.Text);
            f.Salaire = float.Parse(l3.Text);
            Savefonction(f, m, mE);
            chargement(t, d);
        }
        public void deplacerfx(DataGridViewCellEventArgs e, int code, GunaLineTextBox l1, GunaDateTimePicker l2, GunaLineTextBox l3, DataGridView d)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = d.Rows[e.RowIndex];
                id = Convert.ToInt32(r.Cells[0].Value);
                l1.Text = r.Cells[1].Value.ToString();
                l2.Text = r.Cells[2].Value.ToString();
                l3.Text = r.Cells[3].Value.ToString();
            }

        }
        public void avoir(object o)
        {
            M_Avoir a = (M_Avoir)o;
            try
            {
                initConnect();
                con.Open();
                cmd = new SqlCommand("exec p_avoir @id,@datedeb,@datefin,@codefx,@codeag", con);
                cmd.Parameters.AddWithValue("@id", a.Id);
                cmd.Parameters.AddWithValue("@datedeb", a.Date_debut);
                cmd.Parameters.AddWithValue("@datefin", a.Date_fin);
                cmd.Parameters.AddWithValue("codefx", a.Fonction);
                cmd.Parameters.AddWithValue("@codeag", a.Agent);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fonction attribuée avec succes");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void addAvoir(int code, GunaDateTimePicker date1, GunaDateTimePicker date2, ComboBox fx, ComboBox ag, string sql, DataGridView d)
        {
            M_Avoir av = new M_Avoir();
            av.Id = id;
            av.Date_debut = DateTime.Parse(date1.Text);
            av.Date_fin = DateTime.Parse(date2.Text);
            av.Fonction = fx.Text;
            av.Agent = ag.Text;
            avoir(av);
            chargement(sql, d);
        }
        public void deplaceravoir(int code, DataGridViewCellEventArgs ev, GunaDateTimePicker date1, GunaDateTimePicker date2, ComboBox fx, ComboBox ag, DataGridView d)
        {
            if (ev.RowIndex >= 0)
            {
                DataGridViewRow r = d.Rows[ev.RowIndex];
                id = Convert.ToInt32(r.Cells[0].Value);
                date1.Text = r.Cells[1].Value.ToString();
                date2.Text = r.Cells[2].Value.ToString();
                ag.Text = r.Cells[4].Value.ToString();
                fx.Text = r.Cells[5].Value.ToString();
            }
        }

        public void deplacer_affect(DataGridViewCellEventArgs e, DataGridView d, int code, DateTimePicker date1, DateTimePicker date2, ComboBox serv, ComboBox ag)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = d.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value);
                date1.Text = row.Cells[1].Value.ToString();
                date2.Text = row.Cells[2].Value.ToString();
                ag.Text = row.Cells[3].Value.ToString();
                serv.Text = row.Cells[4].Value.ToString();
            }
        }
        public void depacer_Servi(int code, DataGridViewCellEventArgs e, GunaLineTextBox desig, DataGridView d)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = d.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value);
                desig.Text = row.Cells[1].Value.ToString();
            }
        }
        public void concerner(object o)
        {
            M_Concerner c = (M_Concerner)o;
            try
            {
                initConnect();
                con.Open();
                cmd = new SqlCommand("exec p_concerner @id,@montant,@mois,@datepaiement,@agent,@codepaiement", con);
                cmd.Parameters.AddWithValue("@id", c.Id);
                cmd.Parameters.AddWithValue("@montant", c.Montant);
                cmd.Parameters.AddWithValue("@mois", DateTime.Parse(c.Mois));
                cmd.Parameters.AddWithValue("@datepaiement", DateTime.Parse(c.Date_paiement));
                cmd.Parameters.AddWithValue("@agent", c.Agent);
                cmd.Parameters.AddWithValue("@codepaiement", c.Codepaiement);
                // cmd.Parameters.AddWithValue("@mess", c.Message);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bien reussi");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void add_concerner(int code, TextBox montant, DateTimePicker mois, DateTimePicker datpaie, ComboBox ag, ComboBox paie, string sql, DataGridView d)
        {
            M_Concerner co = new M_Concerner();
            co.Id = id;
            co.Montant = montant.Text;
            DateTime.Parse(co.Mois = mois.Text);
            DateTime.Parse(co.Date_paiement = datpaie.Text);
            co.Agent = ag.Text;
            co.Codepaiement = paie.Text;
            concerner(co);
            chargement(sql, d);
        }
        public void deplacer_concerne(int code, DataGridViewCellEventArgs ev, TextBox montant, DateTimePicker mois, DateTimePicker datpaie, ComboBox ag, ComboBox paie, DataGridView d)
        {
            if (ev.RowIndex >= 0)
            {
                DataGridViewRow r = d.Rows[ev.RowIndex];
                id = Convert.ToInt32(r.Cells[0].Value);
                montant.Text = r.Cells[1].Value.ToString();
                mois.Text = r.Cells[2].Value.ToString();
                datpaie.Text = r.Cells[3].Value.ToString();
                ag.Text = r.Cells[4].Value.ToString();
                paie.Text = r.Cells[5].Value.ToString();
            }
        }
        public void effacer(params TextBox [] e)
        {
            //int i;
            for( int i = 0; i < e.Length; i++)
            {
                e[i].Text = "";
            }
        }
        public static void couleur(params Panel [] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                p[i].BackColor = Color.FromArgb(45, 49, 68);
            }
        }
        public void Qrcode(PictureBox pb, string txt)
        {
            Zen.Barcode.BarcodeDraw code = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pb.Image = code.Draw(txt, 40);
        }
        public void matricule(int code, GunaLabel mat)
        {
            try
            {
                initConnect();
                con.Open();
                cmd = new SqlCommand(" select dbo.f_matricule(@matric) as matricule", con);
                cmd.Parameters.AddWithValue("@matric", id);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    mat.Text = dr["matricule"].ToString();
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public void deplaceragent(DataGridViewCellEventArgs e, int code, GunaLabel noms, GunaLabel sexe, GunaLabel fx, PictureBox pb, DataGridView t)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow ro = t.Rows[e.RowIndex];
                id = Convert.ToInt32(ro.Cells[0].Value);
                noms.Text = ro.Cells[1].Value.ToString() + " "+  ro.Cells[2].Value.ToString()+" "+ ro.Cells[3].Value.ToString();
                sexe.Text = ro.Cells[4].Value.ToString();
                fx.Text = ro.Cells[5].Value.ToString();
                MemoryStream ms = new MemoryStream();
                byte[] photo = (byte[])ro.Cells[13].Value;
                ms.Write(photo, 0, photo.Length);
                pb.Image = new System.Drawing.Bitmap(ms);

            }

        }

        public void imprimer(DataTable t, string sql)
        {
            throw new NotImplementedException();
        }
    }
}