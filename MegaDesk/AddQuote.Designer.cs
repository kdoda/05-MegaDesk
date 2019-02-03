namespace MegaDesk
{
    partial class AddQuote
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this._reqTextWidth = new System.Windows.Forms.TextBox();
            this._reqTextCustomerName = new System.Windows.Forms.TextBox();
            this._reqTextDepth = new System.Windows.Forms.TextBox();
            this._reqNumericUpDownNumberDrawers = new System.Windows.Forms.NumericUpDown();
            this._reqComboBoxMaterials = new System.Windows.Forms.ComboBox();
            this._reqComboBoxOrderDays = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.labelNrDrawers = new System.Windows.Forms.Label();
            this.labelSurfaceMaterial = new System.Windows.Forms.Label();
            this.labelOrderDays = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._reqNumericUpDownNumberDrawers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(304, 305);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(109, 50);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // _reqTextWidth
            // 
            this._reqTextWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._reqTextWidth.Location = new System.Drawing.Point(304, 62);
            this._reqTextWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._reqTextWidth.MaxLength = 2;
            this._reqTextWidth.Name = "_reqTextWidth";
            this._reqTextWidth.Size = new System.Drawing.Size(240, 30);
            this._reqTextWidth.TabIndex = 1;
            this._reqTextWidth.Validating += new System.ComponentModel.CancelEventHandler(this.textWidth_Validating);
            this._reqTextWidth.Validated += new System.EventHandler(this.textWidth_Validated);
            // 
            // _reqTextCustomerName
            // 
            this._reqTextCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._reqTextCustomerName.Location = new System.Drawing.Point(304, 15);
            this._reqTextCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._reqTextCustomerName.Name = "_reqTextCustomerName";
            this._reqTextCustomerName.Size = new System.Drawing.Size(240, 30);
            this._reqTextCustomerName.TabIndex = 0;
            // 
            // _reqTextDepth
            // 
            this._reqTextDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._reqTextDepth.Location = new System.Drawing.Point(304, 108);
            this._reqTextDepth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._reqTextDepth.MaxLength = 2;
            this._reqTextDepth.Name = "_reqTextDepth";
            this._reqTextDepth.Size = new System.Drawing.Size(240, 30);
            this._reqTextDepth.TabIndex = 3;
            this._reqTextDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDepth_KeyPress);
            this._reqTextDepth.Validating += new System.ComponentModel.CancelEventHandler(this.textDepth_Validating);
            this._reqTextDepth.Validated += new System.EventHandler(this.textDepth_Validated);
            // 
            // _reqNumericUpDownNumberDrawers
            // 
            this._reqNumericUpDownNumberDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._reqNumericUpDownNumberDrawers.Location = new System.Drawing.Point(304, 153);
            this._reqNumericUpDownNumberDrawers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._reqNumericUpDownNumberDrawers.Name = "_reqNumericUpDownNumberDrawers";
            this._reqNumericUpDownNumberDrawers.Size = new System.Drawing.Size(240, 30);
            this._reqNumericUpDownNumberDrawers.TabIndex = 4;
            // 
            // _reqComboBoxMaterials
            // 
            this._reqComboBoxMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._reqComboBoxMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._reqComboBoxMaterials.FormattingEnabled = true;
            this._reqComboBoxMaterials.Location = new System.Drawing.Point(304, 199);
            this._reqComboBoxMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._reqComboBoxMaterials.Name = "_reqComboBoxMaterials";
            this._reqComboBoxMaterials.Size = new System.Drawing.Size(240, 33);
            this._reqComboBoxMaterials.TabIndex = 5;
            // 
            // _reqComboBoxOrderDays
            // 
            this._reqComboBoxOrderDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._reqComboBoxOrderDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._reqComboBoxOrderDays.FormattingEnabled = true;
            this._reqComboBoxOrderDays.Location = new System.Drawing.Point(304, 251);
            this._reqComboBoxOrderDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._reqComboBoxOrderDays.Name = "_reqComboBoxOrderDays";
            this._reqComboBoxOrderDays.Size = new System.Drawing.Size(240, 33);
            this._reqComboBoxOrderDays.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(175, 305);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 50);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(45, 15);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(240, 30);
            this.labelCustomerName.TabIndex = 10;
            this.labelCustomerName.Text = "Customer Name";
            this.labelCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWidth
            // 
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.Location = new System.Drawing.Point(45, 62);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(240, 30);
            this.labelWidth.TabIndex = 11;
            this.labelWidth.Text = "Desk Width";
            this.labelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDepth
            // 
            this.labelDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepth.Location = new System.Drawing.Point(45, 108);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(240, 30);
            this.labelDepth.TabIndex = 12;
            this.labelDepth.Text = "Desk Depth";
            this.labelDepth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNrDrawers
            // 
            this.labelNrDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNrDrawers.Location = new System.Drawing.Point(45, 153);
            this.labelNrDrawers.Name = "labelNrDrawers";
            this.labelNrDrawers.Size = new System.Drawing.Size(240, 30);
            this.labelNrDrawers.TabIndex = 13;
            this.labelNrDrawers.Text = "Number of Drawers";
            this.labelNrDrawers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSurfaceMaterial
            // 
            this.labelSurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurfaceMaterial.Location = new System.Drawing.Point(45, 199);
            this.labelSurfaceMaterial.Name = "labelSurfaceMaterial";
            this.labelSurfaceMaterial.Size = new System.Drawing.Size(240, 30);
            this.labelSurfaceMaterial.TabIndex = 14;
            this.labelSurfaceMaterial.Text = "Surface Material";
            this.labelSurfaceMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOrderDays
            // 
            this.labelOrderDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderDays.Location = new System.Drawing.Point(45, 251);
            this.labelOrderDays.Name = "labelOrderDays";
            this.labelOrderDays.Size = new System.Drawing.Size(240, 30);
            this.labelOrderDays.TabIndex = 15;
            this.labelOrderDays.Text = "Order Days";
            this.labelOrderDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 402);
            this.Controls.Add(this.labelOrderDays);
            this.Controls.Add(this.labelSurfaceMaterial);
            this.Controls.Add(this.labelNrDrawers);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this._reqComboBoxOrderDays);
            this.Controls.Add(this._reqComboBoxMaterials);
            this.Controls.Add(this._reqNumericUpDownNumberDrawers);
            this.Controls.Add(this._reqTextDepth);
            this.Controls.Add(this._reqTextCustomerName);
            this.Controls.Add(this._reqTextWidth);
            this.Controls.Add(this.buttonCancel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this._reqNumericUpDownNumberDrawers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox _reqTextWidth;
        private System.Windows.Forms.TextBox _reqTextCustomerName;
        private System.Windows.Forms.TextBox _reqTextDepth;
        private System.Windows.Forms.NumericUpDown _reqNumericUpDownNumberDrawers;
        private System.Windows.Forms.ComboBox _reqComboBoxMaterials;
        private System.Windows.Forms.ComboBox _reqComboBoxOrderDays;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelNrDrawers;
        private System.Windows.Forms.Label labelSurfaceMaterial;
        private System.Windows.Forms.Label labelOrderDays;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}