
namespace TestForGAZIT
{
    partial class fChForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbChoose = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgChRef = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChRef)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbChoose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbChoose
            // 
            this.tsbChoose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbChoose.Image = ((System.Drawing.Image)(resources.GetObject("tsbChoose.Image")));
            this.tsbChoose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChoose.Name = "tsbChoose";
            this.tsbChoose.Size = new System.Drawing.Size(58, 22);
            this.tsbChoose.Text = "Выбрать";
            this.tsbChoose.Click += new System.EventHandler(this.tsbChoose_click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.dgChRef);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 403);
            this.panel1.TabIndex = 2;
            // 
            // dgChRef
            // 
            this.dgChRef.AllowUserToAddRows = false;
            this.dgChRef.AllowUserToDeleteRows = false;
            this.dgChRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChRef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgChRef.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgChRef.Location = new System.Drawing.Point(0, 0);
            this.dgChRef.MultiSelect = false;
            this.dgChRef.Name = "dgChRef";
            this.dgChRef.ReadOnly = true;
            this.dgChRef.RowTemplate.Height = 25;
            this.dgChRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChRef.Size = new System.Drawing.Size(800, 403);
            this.dgChRef.TabIndex = 0;
            this.dgChRef.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgChRef_CellContentDoubleClick);
            // 
            // fChForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "fChForm";
            this.Text = "Выбрать";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChRef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbChoose;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgChRef;
    }
}