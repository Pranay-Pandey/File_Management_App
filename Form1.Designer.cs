namespace FileTaggingApp
{
    partial class Form1
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Backbtn = new System.Windows.Forms.Button();
            this.gobtn = new System.Windows.Forms.Button();
            this.filepathtextbox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.filenamelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filetypelabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagName1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internshipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagName2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCustomTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(26, 23);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(75, 23);
            this.Backbtn.TabIndex = 0;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // gobtn
            // 
            this.gobtn.Location = new System.Drawing.Point(713, 23);
            this.gobtn.Name = "gobtn";
            this.gobtn.Size = new System.Drawing.Size(75, 23);
            this.gobtn.TabIndex = 1;
            this.gobtn.Text = "Go";
            this.gobtn.UseVisualStyleBackColor = true;
            this.gobtn.Click += new System.EventHandler(this.gobtn_Click);
            // 
            // filepathtextbox
            // 
            this.filepathtextbox.Location = new System.Drawing.Point(107, 24);
            this.filepathtextbox.Name = "filepathtextbox";
            this.filepathtextbox.Size = new System.Drawing.Size(600, 22);
            this.filepathtextbox.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(26, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(762, 330);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "box.png");
            this.imageList1.Images.SetKeyName(1, "doc.png");
            this.imageList1.Images.SetKeyName(2, "exe.png");
            this.imageList1.Images.SetKeyName(3, "folder.png");
            this.imageList1.Images.SetKeyName(4, "image.png");
            this.imageList1.Images.SetKeyName(5, "mp3.png");
            this.imageList1.Images.SetKeyName(6, "mp4.png");
            this.imageList1.Images.SetKeyName(7, "pdf.png");
            this.imageList1.Images.SetKeyName(8, "unknown-mail.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Name:";
            // 
            // filenamelabel
            // 
            this.filenamelabel.AutoSize = true;
            this.filenamelabel.Location = new System.Drawing.Point(101, 425);
            this.filenamelabel.Name = "filenamelabel";
            this.filenamelabel.Size = new System.Drawing.Size(11, 16);
            this.filenamelabel.TabIndex = 5;
            this.filenamelabel.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "File Type : ";
            // 
            // filetypelabel
            // 
            this.filetypelabel.AutoSize = true;
            this.filetypelabel.Location = new System.Drawing.Point(696, 425);
            this.filetypelabel.Name = "filetypelabel";
            this.filetypelabel.Size = new System.Drawing.Size(11, 16);
            this.filetypelabel.TabIndex = 7;
            this.filetypelabel.Text = "-";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTagToolStripMenuItem,
            this.removeAllTagsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 52);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addTagToolStripMenuItem
            // 
            this.addTagToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tagName1ToolStripMenuItem,
            this.internshipToolStripMenuItem,
            this.tagName2ToolStripMenuItem,
            this.createCustomTagsToolStripMenuItem});
            this.addTagToolStripMenuItem.Name = "addTagToolStripMenuItem";
            this.addTagToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.addTagToolStripMenuItem.Text = "Add Tag";
            this.addTagToolStripMenuItem.Click += new System.EventHandler(this.addTagToolStripMenuItem_Click);
            // 
            // tagName1ToolStripMenuItem
            // 
            this.tagName1ToolStripMenuItem.Name = "tagName1ToolStripMenuItem";
            this.tagName1ToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.tagName1ToolStripMenuItem.Text = "Work";
            this.tagName1ToolStripMenuItem.Click += new System.EventHandler(this.tagName1ToolStripMenuItem_Click);
            // 
            // internshipToolStripMenuItem
            // 
            this.internshipToolStripMenuItem.Name = "internshipToolStripMenuItem";
            this.internshipToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.internshipToolStripMenuItem.Text = "Internship";
            // 
            // tagName2ToolStripMenuItem
            // 
            this.tagName2ToolStripMenuItem.Name = "tagName2ToolStripMenuItem";
            this.tagName2ToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.tagName2ToolStripMenuItem.Text = "College";
            // 
            // createCustomTagsToolStripMenuItem
            // 
            this.createCustomTagsToolStripMenuItem.Name = "createCustomTagsToolStripMenuItem";
            this.createCustomTagsToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.createCustomTagsToolStripMenuItem.Text = "Create Custom Tags";
            // 
            // removeAllTagsToolStripMenuItem
            // 
            this.removeAllTagsToolStripMenuItem.Name = "removeAllTagsToolStripMenuItem";
            this.removeAllTagsToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.removeAllTagsToolStripMenuItem.Text = "Remove All tags";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filetypelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filenamelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.filepathtextbox);
            this.Controls.Add(this.gobtn);
            this.Controls.Add(this.Backbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button gobtn;
        private System.Windows.Forms.TextBox filepathtextbox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label filenamelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label filetypelabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllTagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagName1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagName2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCustomTagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internshipToolStripMenuItem;
    }
}

