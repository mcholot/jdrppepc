
namespace formjdrppe
{
    partial class creationObjets
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
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRarity = new System.Windows.Forms.ComboBox();
            this.descrip = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(111, 61);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(183, 20);
            this.textBoxNom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(70, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Créer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(60, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rareté";
            // 
            // comboBoxRarity
            // 
            this.comboBoxRarity.FormattingEnabled = true;
            this.comboBoxRarity.Location = new System.Drawing.Point(111, 202);
            this.comboBoxRarity.Name = "comboBoxRarity";
            this.comboBoxRarity.Size = new System.Drawing.Size(183, 21);
            this.comboBoxRarity.TabIndex = 8;
            this.comboBoxRarity.SelectedValueChanged += new System.EventHandler(this.comboBoxRarity_SelectedValueChanged);
            // 
            // descrip
            // 
            this.descrip.AutoSize = true;
            this.descrip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.descrip.Location = new System.Drawing.Point(39, 105);
            this.descrip.Name = "descrip";
            this.descrip.Size = new System.Drawing.Size(60, 13);
            this.descrip.TabIndex = 11;
            this.descrip.Text = "Description";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(111, 102);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(183, 79);
            this.textBoxDesc.TabIndex = 10;
            // 
            // creationObjets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(381, 310);
            this.Controls.Add(this.descrip);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.comboBoxRarity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNom);
            this.Name = "creationObjets";
            this.Text = "creationObjets";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.creationObjets_FormClosed);
            this.Load += new System.EventHandler(this.creationObjets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRarity;
        private System.Windows.Forms.Label descrip;
        private System.Windows.Forms.TextBox textBoxDesc;
    }
}