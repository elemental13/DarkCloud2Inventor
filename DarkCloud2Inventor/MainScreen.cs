using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DarkCloud2Inventor.Properties;
using Image = System.Drawing.Image;

namespace DarkCloud2Inventor
{
    public partial class MainScreen : Form
    {
        public string UserAccount { get; set; }

        public static MainScreen ScreenMenu
        {
            get { return _menu ?? (_menu = new MainScreen()); }
        }
        private static MainScreen _menu;

        private readonly DataConnection _db = new DataConnection();

        private readonly DataTable _dt = new DataTable();
        private bool _isBound = false;

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            cloudClock.LoadAsync();
            titlePictureBox.LoadAsync();

            fullPicBox.DataSource = _db.PhotoGallery();
            fullPicBox.DisplayMember = "Name";
            fullPicBox.Refresh();

        }


        private void btnMyGallery_MouseHover(object sender, EventArgs e)
        {
            btnmygallery.ForeColor = Color.Black;
            selectgallery.Visible = true;
        }

        private void btnMyGallery_MouseLeave(object sender, EventArgs e)
        {
            btnmygallery.ForeColor = Color.White;
            selectgallery.Visible = false;
        }

        private void btnMyGallery_Click(Object sender, EventArgs e)
        {
            myPicList.Visible = true;
            myPicList.Items.Clear();

            currentPicBox.Visible = false;
            inventionTitle.Visible = false;
            inventionDesc.Visible = false;
            locationTitle.Visible = false;
            locationDesc.Visible = false;
            addbtn.Visible = false;
            fullPicBox.Visible = false;
            searchbox.Visible = false;

            var myPics = _db.UserGallery(UserAccount);

            foreach (var li in myPics)
            {
                myPicList.Items.Add(li.name);
            }
        }


        private void btninvention_MouseHover(object sender, EventArgs e)
        {
            btninvention.ForeColor = Color.Black;
            selectinvent.Visible = true;
        }

        private void btninvention_MouseLeave(object sender, EventArgs e)
        {
            btninvention.ForeColor = Color.White;
            selectinvent.Visible = false;
        }


        private void btnsearch_MouseHover(object sender, EventArgs e)
        {
            btnsearch.ForeColor = Color.Black;
            selectsearch.Visible = true;
        }

        private void btnsearch_MouseLeave(object sender, EventArgs e)
        {
            btnsearch.ForeColor = Color.White;
            selectsearch.Visible = false;
        }


        private void btnlogout_MouseHover(object sender, EventArgs e)
        {
            btnlogout.ForeColor = Color.Black;
            selectlogout.Visible = true;
        }

        private void btnlogout_MouseLeave(object sender, EventArgs e)
        {
            btnlogout.ForeColor = Color.White;
            selectlogout.Visible = false;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LogIn.LogInMenu.Visible = true;
            LogIn.LogInMenu.Show();
            ScreenMenu.Hide();

            UserAccount = "";
            myPicList.Visible = false;
            myPicList.Items.Clear();

            currentPicBox.Visible = false;
            inventionTitle.Visible = false;
            inventionDesc.Visible = false;
            locationTitle.Visible = false;
            locationDesc.Visible = false;
            addbtn.Visible = false;
            fullPicBox.Visible = false;
            searchbox.Visible = false;
            

        }

        private void myPicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (myPicList.SelectedIndex <= -1) return;
            var currentPicture = myPicList.SelectedItem.ToString();
            var pictureInfo = _db.GetPictureInfo(currentPicture);
            var invList = _db.GetInventionsFromPhoto(currentPicture);

            var invString = new StringBuilder();

            invString.Append(invList.First());

            if (invList.Count > 1)
            {
                foreach (var r in invList)
                {
                    invString.Append(", " + r);
                }

            }

            inventionDesc.Text = invString.ToString();
            

            locationDesc.Text = pictureInfo.location;
            currentPicBox.BackgroundImage = (Image) Resources.ResourceManager.GetObject(pictureInfo.pic);

            currentPicBox.Visible = true;
            inventionTitle.Visible = true;
            inventionDesc.Visible = true;
            locationTitle.Visible = true;
            locationDesc.Visible = true;
        }

        private void myPicList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            myPicList.SelectedIndex = myPicList.IndexFromPoint(e.X, e.Y);
            if (myPicList.SelectedIndex <= -1) return;
            picboxMenuStrip.Show(Cursor.Position);
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            _db.DeletePhoto(UserAccount, myPicList.SelectedItem.ToString());

            btnMyGallery_Click(sender, e);
        }

        private void fullPicBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            fullPicBox.SelectedIndex = fullPicBox.IndexFromPoint(e.X, e.Y);
            if (fullPicBox.SelectedIndex <= -1) return;
            addMenuStrip.Show(Cursor.Position);
        }

        private void addMenuItem_Click(object sender, EventArgs e)
        {
            if (_db.AddPhoto(UserAccount, fullPicBox.SelectedItem.ToString()) == true)
            {
                MessageBox.Show("Photo Added to Gallery!");
            }
            else
            {
                MessageBox.Show("Photo has already been added...");
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            addbtn.Visible = true;
            fullPicBox.Visible = true;

            searchbox.Visible = true;

            myPicList.Visible = false;
            myPicList.Items.Clear();

            currentPicBox.Visible = false;
            inventionTitle.Visible = false;
            inventionDesc.Visible = false;
            locationTitle.Visible = false;
            locationDesc.Visible = false;

        }


        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            fullPicBox.DataSource = (from p in _db.PhotoGallery() where p.name.Contains(searchbox.Text) select p.name).ToList();
            fullPicBox.DisplayMember = "Name";
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (_db.AddPhoto(UserAccount, fullPicBox.SelectedItem.ToString()) == true)
            {
                MessageBox.Show("Photo Added to Gallery!");
            }
            else
            {
                MessageBox.Show("Photo has already been added...");
            }
        }


        private void fullPicBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            fullPicBox.SelectedIndex = fullPicBox.IndexFromPoint(e.X, e.Y);
            if (fullPicBox.SelectedIndex <= -1) return;
            searchbox.Text = fullPicBox.SelectedItem.ToString();
        }

    }
}
