namespace MegaDesk
{
    partial class SearchQuotes
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.lblSurfaceMaterial = new System.Windows.Forms.Label();
            this.comboBoxMaterials = new System.Windows.Forms.ComboBox();
            this.txtQuotes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(760, 356);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 35);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // lblSurfaceMaterial
            // 
            this.lblSurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurfaceMaterial.Location = new System.Drawing.Point(38, 9);
            this.lblSurfaceMaterial.Name = "lblSurfaceMaterial";
            this.lblSurfaceMaterial.Size = new System.Drawing.Size(240, 30);
            this.lblSurfaceMaterial.TabIndex = 16;
            this.lblSurfaceMaterial.Text = "Search Surface Material:";
            this.lblSurfaceMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMaterials
            // 
            this.comboBoxMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMaterials.FormattingEnabled = true;
            this.comboBoxMaterials.Location = new System.Drawing.Point(308, 6);
            this.comboBoxMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMaterials.Name = "comboBoxMaterials";
            this.comboBoxMaterials.Size = new System.Drawing.Size(240, 33);
            this.comboBoxMaterials.TabIndex = 15;
            this.comboBoxMaterials.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaterials_SelectedIndexChanged);
            // 
            // txtQuotes
            // 
            this.txtQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuotes.Location = new System.Drawing.Point(12, 56);
            this.txtQuotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuotes.Multiline = true;
            this.txtQuotes.Name = "txtQuotes";
            this.txtQuotes.ReadOnly = true;
            this.txtQuotes.Size = new System.Drawing.Size(843, 284);
            this.txtQuotes.TabIndex = 17;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 403);
            this.Controls.Add(this.txtQuotes);
            this.Controls.Add(this.lblSurfaceMaterial);
            this.Controls.Add(this.comboBoxMaterials);
            this.Controls.Add(this.buttonCancel);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label lblSurfaceMaterial;
        private System.Windows.Forms.ComboBox comboBoxMaterials;
        private System.Windows.Forms.TextBox txtQuotes;
    }
}