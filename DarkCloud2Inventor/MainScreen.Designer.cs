using System.Net.Mime;
using System.Windows.Forms;

namespace DarkCloud2Inventor
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titlePictureBox = new System.Windows.Forms.PictureBox();
            this.cloudClock = new System.Windows.Forms.PictureBox();
            this.btnmygallery = new System.Windows.Forms.Button();
            this.btninvention = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.selectgallery = new System.Windows.Forms.PictureBox();
            this.selectinvent = new System.Windows.Forms.PictureBox();
            this.selectsearch = new System.Windows.Forms.PictureBox();
            this.selectlogout = new System.Windows.Forms.PictureBox();
            this.currentPicBox = new System.Windows.Forms.PictureBox();
            this.myPicList = new System.Windows.Forms.ListBox();
            this.locationTitle = new System.Windows.Forms.Label();
            this.locationDesc = new System.Windows.Forms.Label();
            this.picboxMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventionTitle = new System.Windows.Forms.Label();
            this.inventionDesc = new System.Windows.Forms.Label();
            this.fullPicBox = new System.Windows.Forms.ListBox();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.addMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectgallery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectinvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectlogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPicBox)).BeginInit();
            this.picboxMenuStrip.SuspendLayout();
            this.addMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePictureBox
            // 
            this.titlePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.titlePictureBox.BackgroundImage = global::DarkCloud2Inventor.Properties.Resources.dc2logo;
            this.titlePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titlePictureBox.Location = new System.Drawing.Point(30, 21);
            this.titlePictureBox.Name = "titlePictureBox";
            this.titlePictureBox.Size = new System.Drawing.Size(411, 214);
            this.titlePictureBox.TabIndex = 1;
            this.titlePictureBox.TabStop = false;
            // 
            // cloudClock
            // 
            this.cloudClock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cloudClock.BackColor = System.Drawing.Color.Transparent;
            this.cloudClock.BackgroundImage = global::DarkCloud2Inventor.Properties.Resources.chronical_clock;
            this.cloudClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cloudClock.Location = new System.Drawing.Point(371, 291);
            this.cloudClock.Name = "cloudClock";
            this.cloudClock.Size = new System.Drawing.Size(557, 503);
            this.cloudClock.TabIndex = 2;
            this.cloudClock.TabStop = false;
            // 
            // btnmygallery
            // 
            this.btnmygallery.BackColor = System.Drawing.Color.Transparent;
            this.btnmygallery.BackgroundImage = global::DarkCloud2Inventor.Properties.Resources.woodbg;
            this.btnmygallery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmygallery.FlatAppearance.BorderSize = 0;
            this.btnmygallery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmygallery.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmygallery.ForeColor = System.Drawing.Color.White;
            this.btnmygallery.Location = new System.Drawing.Point(192, 426);
            this.btnmygallery.Name = "btnmygallery";
            this.btnmygallery.Size = new System.Drawing.Size(119, 38);
            this.btnmygallery.TabIndex = 4;
            this.btnmygallery.Text = "My Gallery";
            this.btnmygallery.UseVisualStyleBackColor = false;
            this.btnmygallery.Click += new System.EventHandler(this.btnMyGallery_Click);
            this.btnmygallery.MouseLeave += new System.EventHandler(this.btnMyGallery_MouseLeave);
            this.btnmygallery.MouseHover += new System.EventHandler(this.btnMyGallery_MouseHover);
            // 
            // btninvention
            // 
            this.btninvention.BackColor = System.Drawing.Color.Transparent;
            this.btninvention.BackgroundImage = global::DarkCloud2Inventor.Properties.Resources.woodbg;
            this.btninvention.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btninvention.FlatAppearance.BorderSize = 0;
            this.btninvention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninvention.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninvention.ForeColor = System.Drawing.Color.White;
            this.btninvention.Location = new System.Drawing.Point(135, 544);
            this.btninvention.Name = "btninvention";
            this.btninvention.Size = new System.Drawing.Size(119, 38);
            this.btninvention.TabIndex = 5;
            this.btninvention.Text = "Inventions";
            this.btninvention.UseVisualStyleBackColor = false;
            this.btninvention.MouseLeave += new System.EventHandler(this.btninvention_MouseLeave);
            this.btninvention.MouseHover += new System.EventHandler(this.btninvention_MouseHover);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Transparent;
            this.btnsearch.BackgroundImage = global::DarkCloud2Inventor.Properties.Resources.woodbg;
            this.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(135, 660);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(119, 38);
            this.btnsearch.TabIndex = 6;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            this.btnsearch.MouseLeave += new System.EventHandler(this.btnsearch_MouseLeave);
            this.btnsearch.MouseHover += new System.EventHandler(this.btnsearch_MouseHover);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Transparent;
            this.btnlogout.BackgroundImage = global::DarkCloud2Inventor.Properties.Resources.woodbg;
            this.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(192, 776);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(119, 38);
            this.btnlogout.TabIndex = 7;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            this.btnlogout.MouseLeave += new System.EventHandler(this.btnlogout_MouseLeave);
            this.btnlogout.MouseHover += new System.EventHandler(this.btnlogout_MouseHover);
            // 
            // selectgallery
            // 
            this.selectgallery.BackColor = System.Drawing.Color.Transparent;
            this.selectgallery.BackgroundImage = global::DarkCloud2Inventor.Properties.Resources.selector;
            this.selectgallery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.selectgallery.Location = new System.Drawing.Point(110, 427);
            this.selectgallery.Name = "selectgallery";
            this.selectgallery.Size = new System.Drawing.Size(76, 37);
            this.selectgallery.TabIndex = 10;
            this.selectgallery.TabStop = false;
            this.selectgallery.Visible = false;
            // 
            // selectinvent
            // 
            this.selectinvent.BackColor = System.Drawing.Color.Transparent;
            this.selectinvent.BackgroundImage = global::DarkCloud2Inventor.Properties.Resources.selector;
            this.selectinvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.selectinvent.Location = new System.Drawing.Point(53, 544);
            this.selectinvent.Name = "selectinvent";
            this.selectinvent.Size = new System.Drawing.Size(76, 37);
            this.selectinvent.TabIndex = 11;
            this.selectinvent.TabStop = false;
            this.selectinvent.Visible = false;
            // 
            // selectsearch
            // 
            this.selectsearch.BackColor = System.Drawing.Color.Transparent;
            this.selectsearch.BackgroundImage = global::DarkCloud2Inventor.Properties.Resources.selector;
            this.selectsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.selectsearch.Location = new System.Drawing.Point(53, 661);
            this.selectsearch.Name = "selectsearch";
            this.selectsearch.Size = new System.Drawing.Size(76, 37);
            this.selectsearch.TabIndex = 12;
            this.selectsearch.TabStop = false;
            this.selectsearch.Visible = false;
            // 
            // selectlogout
            // 
            this.selectlogout.BackColor = System.Drawing.Color.Transparent;
            this.selectlogout.BackgroundImage = global::DarkCloud2Inventor.Properties.Resources.selector;
            this.selectlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.selectlogout.Location = new System.Drawing.Point(110, 776);
            this.selectlogout.Name = "selectlogout";
            this.selectlogout.Size = new System.Drawing.Size(76, 37);
            this.selectlogout.TabIndex = 13;
            this.selectlogout.TabStop = false;
            this.selectlogout.Visible = false;
            // 
            // currentPicBox
            // 
            this.currentPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPicBox.BackColor = System.Drawing.Color.Transparent;
            this.currentPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.currentPicBox.Location = new System.Drawing.Point(907, 21);
            this.currentPicBox.Name = "currentPicBox";
            this.currentPicBox.Size = new System.Drawing.Size(547, 425);
            this.currentPicBox.TabIndex = 14;
            this.currentPicBox.TabStop = false;
            this.currentPicBox.Visible = false;
            // 
            // myPicList
            // 
            this.myPicList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.myPicList.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myPicList.FormattingEnabled = true;
            this.myPicList.ItemHeight = 24;
            this.myPicList.Location = new System.Drawing.Point(907, 587);
            this.myPicList.Name = "myPicList";
            this.myPicList.Size = new System.Drawing.Size(547, 148);
            this.myPicList.TabIndex = 15;
            this.myPicList.Visible = false;
            this.myPicList.SelectedIndexChanged += new System.EventHandler(this.myPicList_SelectedIndexChanged);
            this.myPicList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myPicList_MouseDown);
            // 
            // locationTitle
            // 
            this.locationTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locationTitle.AutoSize = true;
            this.locationTitle.BackColor = System.Drawing.Color.Transparent;
            this.locationTitle.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTitle.Location = new System.Drawing.Point(903, 499);
            this.locationTitle.Name = "locationTitle";
            this.locationTitle.Size = new System.Drawing.Size(98, 24);
            this.locationTitle.TabIndex = 16;
            this.locationTitle.Text = "Location:";
            this.locationTitle.Visible = false;
            // 
            // locationDesc
            // 
            this.locationDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locationDesc.AutoSize = true;
            this.locationDesc.BackColor = System.Drawing.Color.Transparent;
            this.locationDesc.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationDesc.Location = new System.Drawing.Point(1007, 499);
            this.locationDesc.MaximumSize = new System.Drawing.Size(510, 168);
            this.locationDesc.Name = "locationDesc";
            this.locationDesc.Size = new System.Drawing.Size(121, 24);
            this.locationDesc.TabIndex = 17;
            this.locationDesc.Text = "Description...";
            this.locationDesc.Visible = false;
            // 
            // picboxMenuStrip
            // 
            this.picboxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteMenuItem});
            this.picboxMenuStrip.Name = "picboxMenuStrip";
            this.picboxMenuStrip.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteMenuItem.Text = "Delete";
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // inventionTitle
            // 
            this.inventionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inventionTitle.AutoSize = true;
            this.inventionTitle.BackColor = System.Drawing.Color.Transparent;
            this.inventionTitle.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventionTitle.Location = new System.Drawing.Point(903, 463);
            this.inventionTitle.Name = "inventionTitle";
            this.inventionTitle.Size = new System.Drawing.Size(90, 24);
            this.inventionTitle.TabIndex = 19;
            this.inventionTitle.Text = "Used In:";
            this.inventionTitle.Visible = false;
            // 
            // inventionDesc
            // 
            this.inventionDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inventionDesc.AutoSize = true;
            this.inventionDesc.BackColor = System.Drawing.Color.Transparent;
            this.inventionDesc.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventionDesc.Location = new System.Drawing.Point(1007, 463);
            this.inventionDesc.Name = "inventionDesc";
            this.inventionDesc.Size = new System.Drawing.Size(121, 24);
            this.inventionDesc.TabIndex = 20;
            this.inventionDesc.Text = "Description...";
            this.inventionDesc.Visible = false;
            // 
            // fullPicBox
            // 
            this.fullPicBox.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullPicBox.FormattingEnabled = true;
            this.fullPicBox.ItemHeight = 24;
            this.fullPicBox.Location = new System.Drawing.Point(491, 587);
            this.fullPicBox.Name = "fullPicBox";
            this.fullPicBox.Size = new System.Drawing.Size(270, 148);
            this.fullPicBox.TabIndex = 21;
            this.fullPicBox.Visible = false;
            this.fullPicBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fullPicBox_MouseClick);
            this.fullPicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fullPicBox_MouseDown);
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(491, 532);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(176, 31);
            this.searchbox.TabIndex = 22;
            this.searchbox.Visible = false;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Transparent;
            this.addbtn.BackgroundImage = global::DarkCloud2Inventor.Properties.Resources.woodbg;
            this.addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.Location = new System.Drawing.Point(686, 528);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 38);
            this.addbtn.TabIndex = 23;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Visible = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // addMenuStrip
            // 
            this.addMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuItem});
            this.addMenuStrip.Name = "picboxMenuStrip";
            this.addMenuStrip.Size = new System.Drawing.Size(97, 26);
            // 
            // addMenuItem
            // 
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addMenuItem.Text = "Add";
            this.addMenuItem.Click += new System.EventHandler(this.addMenuItem_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DarkCloud2Inventor.Properties.Resources.brownbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1536, 835);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.fullPicBox);
            this.Controls.Add(this.inventionDesc);
            this.Controls.Add(this.inventionTitle);
            this.Controls.Add(this.locationDesc);
            this.Controls.Add(this.locationTitle);
            this.Controls.Add(this.myPicList);
            this.Controls.Add(this.currentPicBox);
            this.Controls.Add(this.selectlogout);
            this.Controls.Add(this.selectsearch);
            this.Controls.Add(this.selectinvent);
            this.Controls.Add(this.selectgallery);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btninvention);
            this.Controls.Add(this.btnmygallery);
            this.Controls.Add(this.cloudClock);
            this.Controls.Add(this.titlePictureBox);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectgallery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectinvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectlogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPicBox)).EndInit();
            this.picboxMenuStrip.ResumeLayout(false);
            this.addMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox titlePictureBox;
        private PictureBox cloudClock;
        private Button btnmygallery;
        private Button btninvention;
        private Button btnsearch;
        private Button btnlogout;
        private PictureBox selectgallery;
        private PictureBox selectinvent;
        private PictureBox selectsearch;
        private PictureBox selectlogout;
        private PictureBox currentPicBox;
        private ListBox myPicList;
        private Label locationTitle;
        private Label locationDesc;
        private ContextMenuStrip picboxMenuStrip;
        private ToolStripMenuItem deleteMenuItem;
        private Label inventionTitle;
        private Label inventionDesc;
        private ListBox fullPicBox;
        private TextBox searchbox;
        private Button addbtn;
        private ContextMenuStrip addMenuStrip;
        private ToolStripMenuItem addMenuItem;
    }
}