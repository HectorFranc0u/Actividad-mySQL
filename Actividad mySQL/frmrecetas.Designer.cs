
namespace Actividad_mySQL
{
    partial class frmrecetas
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
            this.metrolabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txbname = new MetroFramework.Controls.MetroTextBox();
            this.txbingredientes = new MetroFramework.Controls.MetroTextBox();
            this.txbtipo = new MetroFramework.Controls.MetroTextBox();
            this.txbautor = new MetroFramework.Controls.MetroTextBox();
            this.btnagregar = new MetroFramework.Controls.MetroButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Actions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.rdbnuevo = new MetroFramework.Controls.MetroRadioButton();
            this.rdbactualizar = new MetroFramework.Controls.MetroRadioButton();
            this.txbid = new MetroFramework.Controls.MetroTextBox();
            this.lblid = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.Actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // metrolabel1
            // 
            this.metrolabel1.AutoSize = true;
            this.metrolabel1.Location = new System.Drawing.Point(24, 38);
            this.metrolabel1.Name = "metrolabel1";
            this.metrolabel1.Size = new System.Drawing.Size(61, 20);
            this.metrolabel1.TabIndex = 0;
            this.metrolabel1.Text = "Nombre";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Tipo";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 139);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 20);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Ingredientes";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 184);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(43, 20);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Autor";
            // 
            // txbname
            // 
            // 
            // 
            // 
            this.txbname.CustomButton.Image = null;
            this.txbname.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txbname.CustomButton.Name = "";
            this.txbname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbname.CustomButton.TabIndex = 1;
            this.txbname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbname.CustomButton.UseSelectable = true;
            this.txbname.CustomButton.Visible = false;
            this.txbname.Lines = new string[0];
            this.txbname.Location = new System.Drawing.Point(166, 38);
            this.txbname.MaxLength = 32767;
            this.txbname.Name = "txbname";
            this.txbname.PasswordChar = '\0';
            this.txbname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbname.SelectedText = "";
            this.txbname.SelectionLength = 0;
            this.txbname.SelectionStart = 0;
            this.txbname.ShortcutsEnabled = true;
            this.txbname.Size = new System.Drawing.Size(163, 23);
            this.txbname.TabIndex = 5;
            this.txbname.UseSelectable = true;
            this.txbname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbingredientes
            // 
            // 
            // 
            // 
            this.txbingredientes.CustomButton.Image = null;
            this.txbingredientes.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txbingredientes.CustomButton.Name = "";
            this.txbingredientes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbingredientes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbingredientes.CustomButton.TabIndex = 1;
            this.txbingredientes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbingredientes.CustomButton.UseSelectable = true;
            this.txbingredientes.CustomButton.Visible = false;
            this.txbingredientes.Lines = new string[0];
            this.txbingredientes.Location = new System.Drawing.Point(166, 136);
            this.txbingredientes.MaxLength = 32767;
            this.txbingredientes.Name = "txbingredientes";
            this.txbingredientes.PasswordChar = '\0';
            this.txbingredientes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbingredientes.SelectedText = "";
            this.txbingredientes.SelectionLength = 0;
            this.txbingredientes.SelectionStart = 0;
            this.txbingredientes.ShortcutsEnabled = true;
            this.txbingredientes.Size = new System.Drawing.Size(163, 23);
            this.txbingredientes.TabIndex = 6;
            this.txbingredientes.UseSelectable = true;
            this.txbingredientes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbingredientes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbtipo
            // 
            // 
            // 
            // 
            this.txbtipo.CustomButton.Image = null;
            this.txbtipo.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txbtipo.CustomButton.Name = "";
            this.txbtipo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbtipo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbtipo.CustomButton.TabIndex = 1;
            this.txbtipo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbtipo.CustomButton.UseSelectable = true;
            this.txbtipo.CustomButton.Visible = false;
            this.txbtipo.Lines = new string[0];
            this.txbtipo.Location = new System.Drawing.Point(166, 89);
            this.txbtipo.MaxLength = 32767;
            this.txbtipo.Name = "txbtipo";
            this.txbtipo.PasswordChar = '\0';
            this.txbtipo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbtipo.SelectedText = "";
            this.txbtipo.SelectionLength = 0;
            this.txbtipo.SelectionStart = 0;
            this.txbtipo.ShortcutsEnabled = true;
            this.txbtipo.Size = new System.Drawing.Size(163, 23);
            this.txbtipo.TabIndex = 8;
            this.txbtipo.UseSelectable = true;
            this.txbtipo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbtipo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbautor
            // 
            // 
            // 
            // 
            this.txbautor.CustomButton.Image = null;
            this.txbautor.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txbautor.CustomButton.Name = "";
            this.txbautor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbautor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbautor.CustomButton.TabIndex = 1;
            this.txbautor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbautor.CustomButton.UseSelectable = true;
            this.txbautor.CustomButton.Visible = false;
            this.txbautor.Lines = new string[0];
            this.txbautor.Location = new System.Drawing.Point(166, 181);
            this.txbautor.MaxLength = 32767;
            this.txbautor.Name = "txbautor";
            this.txbautor.PasswordChar = '\0';
            this.txbautor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbautor.SelectedText = "";
            this.txbautor.SelectionLength = 0;
            this.txbautor.SelectionStart = 0;
            this.txbautor.ShortcutsEnabled = true;
            this.txbautor.Size = new System.Drawing.Size(163, 23);
            this.txbautor.TabIndex = 9;
            this.txbautor.UseSelectable = true;
            this.txbautor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbautor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.Coral;
            this.btnagregar.Location = new System.Drawing.Point(415, 164);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(180, 59);
            this.btnagregar.TabIndex = 10;
            this.btnagregar.Text = "guardar";
            this.btnagregar.UseSelectable = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ContextMenuStrip = this.Actions;
            this.dgv.Location = new System.Drawing.Point(24, 311);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(571, 215);
            this.dgv.TabIndex = 11;
            // 
            // Actions
            // 
            this.Actions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Actions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit,
            this.Delete});
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(211, 80);
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(122, 24);
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(210, 24);
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // rdbnuevo
            // 
            this.rdbnuevo.AutoSize = true;
            this.rdbnuevo.Checked = true;
            this.rdbnuevo.Location = new System.Drawing.Point(415, 38);
            this.rdbnuevo.Name = "rdbnuevo";
            this.rdbnuevo.Size = new System.Drawing.Size(62, 17);
            this.rdbnuevo.TabIndex = 12;
            this.rdbnuevo.TabStop = true;
            this.rdbnuevo.Text = "Nuevo";
            this.rdbnuevo.UseSelectable = true;
            // 
            // rdbactualizar
            // 
            this.rdbactualizar.AutoSize = true;
            this.rdbactualizar.Enabled = false;
            this.rdbactualizar.Location = new System.Drawing.Point(415, 61);
            this.rdbactualizar.Name = "rdbactualizar";
            this.rdbactualizar.Size = new System.Drawing.Size(80, 17);
            this.rdbactualizar.TabIndex = 13;
            this.rdbactualizar.Text = "Actualizar";
            this.rdbactualizar.UseSelectable = true;
            // 
            // txbid
            // 
            // 
            // 
            // 
            this.txbid.CustomButton.Image = null;
            this.txbid.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txbid.CustomButton.Name = "";
            this.txbid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbid.CustomButton.TabIndex = 1;
            this.txbid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbid.CustomButton.UseSelectable = true;
            this.txbid.CustomButton.Visible = false;
            this.txbid.Enabled = false;
            this.txbid.Lines = new string[0];
            this.txbid.Location = new System.Drawing.Point(166, 232);
            this.txbid.MaxLength = 32767;
            this.txbid.Name = "txbid";
            this.txbid.PasswordChar = '\0';
            this.txbid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbid.SelectedText = "";
            this.txbid.SelectionLength = 0;
            this.txbid.SelectionStart = 0;
            this.txbid.ShortcutsEnabled = true;
            this.txbid.Size = new System.Drawing.Size(163, 23);
            this.txbid.TabIndex = 14;
            this.txbid.UseSelectable = true;
            this.txbid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(24, 232);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(99, 20);
            this.lblid.TabIndex = 15;
            this.lblid.Text = "ID de la receta";
            // 
            // frmrecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 538);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txbid);
            this.Controls.Add(this.rdbactualizar);
            this.Controls.Add(this.rdbnuevo);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txbautor);
            this.Controls.Add(this.txbtipo);
            this.Controls.Add(this.txbingredientes);
            this.Controls.Add(this.txbname);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metrolabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmrecetas";
            this.Text = "frmrecetas";
            this.Load += new System.EventHandler(this.frmrecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.Actions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metrolabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txbname;
        private MetroFramework.Controls.MetroTextBox txbingredientes;
        private MetroFramework.Controls.MetroTextBox txbtipo;
        private MetroFramework.Controls.MetroTextBox txbautor;
        private MetroFramework.Controls.MetroButton btnagregar;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ContextMenuStrip Actions;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private MetroFramework.Controls.MetroRadioButton rdbnuevo;
        private MetroFramework.Controls.MetroRadioButton rdbactualizar;
        private MetroFramework.Controls.MetroTextBox txbid;
        private MetroFramework.Controls.MetroLabel lblid;
    }
}