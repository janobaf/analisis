
namespace principal
{
    partial class mesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mesa));
            this.label1 = new System.Windows.Forms.Label();
            this.numero_mesa_text = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saliir = new FontAwesome.Sharp.IconButton();
            this.funcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // numero_mesa_text
            // 
            resources.ApplyResources(this.numero_mesa_text, "numero_mesa_text");
            this.numero_mesa_text.Name = "numero_mesa_text";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.saliir);
            this.panel1.Controls.Add(this.numero_mesa_text);
            this.panel1.Name = "panel1";
            // 
            // saliir
            // 
            resources.ApplyResources(this.saliir, "saliir");
            this.saliir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.saliir.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.saliir.IconColor = System.Drawing.Color.Black;
            this.saliir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saliir.IconSize = 25;
            this.saliir.Name = "saliir";
            this.saliir.UseVisualStyleBackColor = false;
            this.saliir.Click += new System.EventHandler(this.saliir_Click);
            // 
            // mesa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "mesa";
            this.Load += new System.EventHandler(this.mesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numero_mesa_text;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource funcionBindingSource1;
        private System.Windows.Forms.BindingSource funcionBindingSource;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton saliir;
    }
}