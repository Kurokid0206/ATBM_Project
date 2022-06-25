using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlCSYT.SqlConn;
using System.Data.Common;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using qlCSYT;

namespace qlCSYT
{
    partial class frm_ViewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ViewUser));
            this.gv_User = new System.Windows.Forms.DataGridView();
            this.gv_update_col_priv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_update_col_priv)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_User
            // 
            this.gv_User.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_User.Location = new System.Drawing.Point(12, 33);
            this.gv_User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gv_User.Name = "gv_User";
            this.gv_User.RowHeadersWidth = 51;
            this.gv_User.RowTemplate.Height = 24;
            this.gv_User.Size = new System.Drawing.Size(853, 241);
            this.gv_User.TabIndex = 0;
            // 
            // gv_update_col_priv
            // 
            this.gv_update_col_priv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_update_col_priv.Location = new System.Drawing.Point(15, 318);
            this.gv_update_col_priv.Name = "gv_update_col_priv";
            this.gv_update_col_priv.RowHeadersWidth = 51;
            this.gv_update_col_priv.RowTemplate.Height = 24;
            this.gv_update_col_priv.Size = new System.Drawing.Size(849, 211);
            this.gv_update_col_priv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Table privileges";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Update column privileges";
            // 
            // frm_ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 568);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gv_update_col_priv);
            this.Controls.Add(this.gv_User);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_ViewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View User";
            this.Load += new System.EventHandler(this.frm_ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_update_col_priv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_User;
        private DataGridView gv_update_col_priv;
        private Label label1;
        private Label label2;
    }
}