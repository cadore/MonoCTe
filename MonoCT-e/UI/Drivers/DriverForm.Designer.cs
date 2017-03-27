namespace MonoCT_e.UI.Drivers
{
    partial class DriverForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.bdgDriver = new System.Windows.Forms.BindingSource(this.components);
            this.lbErrorCPF = new DevExpress.XtraEditors.LabelControl();
            this.tfMobile = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tfCpf = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tfName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCpf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 140);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(516, 45);
            this.panelControl1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(285, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(401, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tfId);
            this.groupControl1.Controls.Add(this.lbErrorCPF);
            this.groupControl1.Controls.Add(this.tfMobile);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.tfCpf);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.tfName);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(516, 140);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Motoristas";
            // 
            // tfId
            // 
            this.tfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgDriver, "id", true));
            this.tfId.Location = new System.Drawing.Point(433, 44);
            this.tfId.Name = "tfId";
            this.tfId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfId.Properties.ReadOnly = true;
            this.tfId.Size = new System.Drawing.Size(78, 20);
            this.tfId.TabIndex = 3;
            this.tfId.TabStop = false;
            // 
            // bdgDriver
            // 
            this.bdgDriver.DataSource = typeof(MonoCT_e.driver);
            // 
            // lbErrorCPF
            // 
            this.lbErrorCPF.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbErrorCPF.Location = new System.Drawing.Point(69, 112);
            this.lbErrorCPF.Name = "lbErrorCPF";
            this.lbErrorCPF.Size = new System.Drawing.Size(120, 13);
            this.lbErrorCPF.TabIndex = 2;
            this.lbErrorCPF.Text = "CPF Incorreto, verifique!";
            this.lbErrorCPF.Visible = false;
            // 
            // tfMobile
            // 
            this.tfMobile.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgDriver, "phone", true));
            this.tfMobile.Location = new System.Drawing.Point(262, 93);
            this.tfMobile.Name = "tfMobile";
            this.tfMobile.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfMobile.Size = new System.Drawing.Size(249, 20);
            this.tfMobile.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(262, 74);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Celular";
            // 
            // tfCpf
            // 
            this.tfCpf.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgDriver, "cpf", true));
            this.tfCpf.Location = new System.Drawing.Point(5, 93);
            this.tfCpf.Name = "tfCpf";
            this.tfCpf.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfCpf.Properties.Mask.EditMask = "000.000.000-00";
            this.tfCpf.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tfCpf.Size = new System.Drawing.Size(251, 20);
            this.tfCpf.TabIndex = 1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Informe o numero do CPF";
            this.validator.SetValidationRule(this.tfCpf, conditionValidationRule3);
            this.tfCpf.Leave += new System.EventHandler(this.tfCpf_Leave);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(19, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "CPF";
            // 
            // tfName
            // 
            this.tfName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgDriver, "full_name", true));
            this.tfName.Location = new System.Drawing.Point(5, 44);
            this.tfName.Name = "tfName";
            this.tfName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfName.Size = new System.Drawing.Size(422, 20);
            this.tfName.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe o Nome do motorista";
            this.validator.SetValidationRule(this.tfName, conditionValidationRule1);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(433, 25);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "ID Interno";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nome Completo";
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "DriverForm";
            this.Size = new System.Drawing.Size(516, 185);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCpf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private WCButtons.Black.ButtonSaveBlack btnSave;
        private DevExpress.XtraEditors.TextEdit tfMobile;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tfCpf;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tfName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbErrorCPF;
        private DevExpress.XtraEditors.TextEdit tfId;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.BindingSource bdgDriver;
    }
}
