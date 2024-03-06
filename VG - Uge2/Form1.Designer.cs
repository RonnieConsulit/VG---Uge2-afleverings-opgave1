namespace VG___Uge2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tilføj_txtbox = new TextBox();
            tilføj_but = new Button();
            slet_txtbox = new TextBox();
            slet_but = new Button();
            tilføj_label = new Label();
            slet_label = new Label();
            displayarr_listbox = new ListBox();
            sort_but = new Button();
            rsort_but = new Button();
            SuspendLayout();
            // 
            // tilføj_txtbox
            // 
            tilføj_txtbox.Location = new Point(154, 114);
            tilføj_txtbox.Name = "tilføj_txtbox";
            tilføj_txtbox.Size = new Size(198, 23);
            tilføj_txtbox.TabIndex = 1;
            tilføj_txtbox.TextChanged += textBox1_TextChanged;
            // 
            // tilføj_but
            // 
            tilføj_but.Location = new Point(154, 143);
            tilføj_but.Name = "tilføj_but";
            tilføj_but.Size = new Size(198, 23);
            tilføj_but.TabIndex = 2;
            tilføj_but.Text = "Tilføj navn";
            tilføj_but.UseVisualStyleBackColor = true;
            tilføj_but.Click += button1_Click;
            // 
            // slet_txtbox
            // 
            slet_txtbox.Location = new Point(154, 195);
            slet_txtbox.Name = "slet_txtbox";
            slet_txtbox.Size = new Size(198, 23);
            slet_txtbox.TabIndex = 3;
            // 
            // slet_but
            // 
            slet_but.Location = new Point(154, 224);
            slet_but.Name = "slet_but";
            slet_but.Size = new Size(198, 23);
            slet_but.TabIndex = 4;
            slet_but.Text = "Slet element";
            slet_but.UseVisualStyleBackColor = true;
            slet_but.Click += button2_Click;
            // 
            // tilføj_label
            // 
            tilføj_label.AutoSize = true;
            tilføj_label.Location = new Point(113, 122);
            tilføj_label.Name = "tilføj_label";
            tilføj_label.Size = new Size(35, 15);
            tilføj_label.TabIndex = 5;
            tilføj_label.Text = "Navn";
            tilføj_label.Click += label1_Click_1;
            // 
            // slet_label
            // 
            slet_label.AutoSize = true;
            slet_label.Location = new Point(22, 198);
            slet_label.Name = "slet_label";
            slet_label.Size = new Size(126, 15);
            slet_label.TabIndex = 6;
            slet_label.Text = "Slet position eller navn";
            slet_label.Click += label2_Click;
            // 
            // displayarr_listbox
            // 
            displayarr_listbox.FormattingEnabled = true;
            displayarr_listbox.ItemHeight = 15;
            displayarr_listbox.Location = new Point(449, 114);
            displayarr_listbox.Name = "displayarr_listbox";
            displayarr_listbox.Size = new Size(248, 244);
            displayarr_listbox.TabIndex = 7;
            displayarr_listbox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            displayarr_listbox.MouseDoubleClick += displayarr_listbox_MouseDoubleClick;
            // 
            // sort_but
            // 
            sort_but.Location = new Point(491, 373);
            sort_but.Name = "sort_but";
            sort_but.Size = new Size(74, 23);
            sort_but.TabIndex = 8;
            sort_but.Text = "Sorter";
            sort_but.UseVisualStyleBackColor = true;
            sort_but.Click += button1_Click_1;
            // 
            // rsort_but
            // 
            rsort_but.Location = new Point(589, 373);
            rsort_but.Name = "rsort_but";
            rsort_but.Size = new Size(74, 23);
            rsort_but.TabIndex = 9;
            rsort_but.Text = "R_Sorter";
            rsort_but.UseVisualStyleBackColor = true;
            rsort_but.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rsort_but);
            Controls.Add(sort_but);
            Controls.Add(displayarr_listbox);
            Controls.Add(slet_label);
            Controls.Add(tilføj_label);
            Controls.Add(slet_but);
            Controls.Add(slet_txtbox);
            Controls.Add(tilføj_but);
            Controls.Add(tilføj_txtbox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tilføj_txtbox;
        private Button tilføj_but;
        private TextBox slet_txtbox;
        private Button slet_but;
        private Label tilføj_label;
        private Label slet_label;
        private ListBox displayarr_listbox;
        private Button sort_but;
        private Button rsort_but;
    }
}
