namespace Proiect
{
    partial class FormPortofoliu
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNumar = new System.Windows.Forms.TextBox();
            this.cbTipPortofoliu = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.schimbaCuloareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serializareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(132)))), ((int)(((byte)(94)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(45, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Creare Portofoliu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id Portofoliu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numar Actiuni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tip Portofoliu";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(194, 70);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 22);
            this.tbId.TabIndex = 6;
            // 
            // tbNumar
            // 
            this.tbNumar.Location = new System.Drawing.Point(194, 124);
            this.tbNumar.Name = "tbNumar";
            this.tbNumar.Size = new System.Drawing.Size(100, 22);
            this.tbNumar.TabIndex = 7;
            // 
            // cbTipPortofoliu
            // 
            this.cbTipPortofoliu.FormattingEnabled = true;
            this.cbTipPortofoliu.Items.AddRange(new object[] {
            "conservator",
            "moderat",
            "echilibrat",
            "de crestere",
            "agresiv"});
            this.cbTipPortofoliu.Location = new System.Drawing.Point(194, 185);
            this.cbTipPortofoliu.Name = "cbTipPortofoliu";
            this.cbTipPortofoliu.Size = new System.Drawing.Size(100, 24);
            this.cbTipPortofoliu.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.OldLace;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(363, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(360, 199);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id Portofoliu";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Numar Actiuni";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tip portofoliu";
            this.columnHeader3.Width = 100;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schimbaCuloareToolStripMenuItem,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 52);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // schimbaCuloareToolStripMenuItem
            // 
            this.schimbaCuloareToolStripMenuItem.Name = "schimbaCuloareToolStripMenuItem";
            this.schimbaCuloareToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.schimbaCuloareToolStripMenuItem.Text = "Schimba culoare";
            this.schimbaCuloareToolStripMenuItem.Click += new System.EventHandler(this.schimbaCuloareToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem1.Text = "Schimba font";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(363, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 69);
            this.button5.TabIndex = 12;
            this.button5.Text = "Insert in listview\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 69);
            this.button2.TabIndex = 13;
            this.button2.Text = "Sterge din listview";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(649, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 69);
            this.button3.TabIndex = 14;
            this.button3.Text = "Salvare din listview";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(464, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 69);
            this.button4.TabIndex = 15;
            this.button4.Text = "Afisare";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareXMLToolStripMenuItem,
            this.deserializareXMLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serializareXMLToolStripMenuItem
            // 
            this.serializareXMLToolStripMenuItem.Name = "serializareXMLToolStripMenuItem";
            this.serializareXMLToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.serializareXMLToolStripMenuItem.Text = "SerializareXML";
            this.serializareXMLToolStripMenuItem.Click += new System.EventHandler(this.serializareXMLToolStripMenuItem_Click);
            // 
            // deserializareXMLToolStripMenuItem
            // 
            this.deserializareXMLToolStripMenuItem.Name = "deserializareXMLToolStripMenuItem";
            this.deserializareXMLToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.deserializareXMLToolStripMenuItem.Text = "DeserializareXML";
            this.deserializareXMLToolStripMenuItem.Click += new System.EventHandler(this.deserializareXMLToolStripMenuItem_Click);
            // 
            // FormPortofoliu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(213)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cbTipPortofoliu);
            this.Controls.Add(this.tbNumar);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPortofoliu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNumar;
        private System.Windows.Forms.ComboBox cbTipPortofoliu;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializareXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareXMLToolStripMenuItem;
    }
}