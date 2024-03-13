using System;

namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSigno = new System.Windows.Forms.Button();
            this.BtnCero = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.tbnUno = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtResultado.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtResultado.Location = new System.Drawing.Point(12, 12);
            this.txtResultado.MaxLength = 20;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(245, 42);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.UseWaitCursor = true;
            // 
            // btnSigno
            // 
            this.btnSigno.BackColor = System.Drawing.Color.DimGray;
            this.btnSigno.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSigno.Location = new System.Drawing.Point(12, 312);
            this.btnSigno.Name = "btnSigno";
            this.btnSigno.Size = new System.Drawing.Size(62, 46);
            this.btnSigno.TabIndex = 1;
            this.btnSigno.Text = "⁺⁄₋";
            this.btnSigno.UseVisualStyleBackColor = false;
            this.btnSigno.Click += new System.EventHandler(this.btnSigno_Click);
            // 
            // BtnCero
            // 
            this.BtnCero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCero.BackColor = System.Drawing.Color.DimGray;
            this.BtnCero.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCero.Location = new System.Drawing.Point(73, 312);
            this.BtnCero.Name = "BtnCero";
            this.BtnCero.Size = new System.Drawing.Size(62, 46);
            this.BtnCero.TabIndex = 2;
            this.BtnCero.Text = "0";
            this.BtnCero.UseVisualStyleBackColor = false;
            this.BtnCero.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.Color.DimGray;
            this.btnPunto.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPunto.Location = new System.Drawing.Point(134, 312);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(62, 46);
            this.btnPunto.TabIndex = 3;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.DimGray;
            this.btnTres.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTres.Location = new System.Drawing.Point(134, 267);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(62, 46);
            this.btnTres.TabIndex = 6;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnDos
            // 
            this.btnDos.BackColor = System.Drawing.Color.DimGray;
            this.btnDos.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDos.Location = new System.Drawing.Point(73, 267);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(62, 46);
            this.btnDos.TabIndex = 5;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = false;
            this.btnDos.Click += new System.EventHandler(this.agregarNumero);
            // 
            // tbnUno
            // 
            this.tbnUno.BackColor = System.Drawing.Color.DimGray;
            this.tbnUno.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnUno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbnUno.Location = new System.Drawing.Point(12, 267);
            this.tbnUno.Name = "tbnUno";
            this.tbnUno.Size = new System.Drawing.Size(62, 46);
            this.tbnUno.TabIndex = 4;
            this.tbnUno.Text = "1";
            this.tbnUno.UseVisualStyleBackColor = false;
            this.tbnUno.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.Color.DimGray;
            this.btnSeis.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeis.Location = new System.Drawing.Point(134, 222);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(62, 46);
            this.btnSeis.TabIndex = 9;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.Color.DimGray;
            this.btnCinco.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCinco.Location = new System.Drawing.Point(73, 222);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(62, 46);
            this.btnCinco.TabIndex = 8;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCuatro
            // 
            this.btnCuatro.BackColor = System.Drawing.Color.DimGray;
            this.btnCuatro.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCuatro.Location = new System.Drawing.Point(12, 222);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(62, 46);
            this.btnCuatro.TabIndex = 7;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = false;
            this.btnCuatro.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnNueve
            // 
            this.btnNueve.BackColor = System.Drawing.Color.DimGray;
            this.btnNueve.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNueve.Location = new System.Drawing.Point(134, 177);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(62, 46);
            this.btnNueve.TabIndex = 12;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = false;
            this.btnNueve.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnOcho
            // 
            this.btnOcho.BackColor = System.Drawing.Color.DimGray;
            this.btnOcho.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOcho.Location = new System.Drawing.Point(73, 177);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(62, 46);
            this.btnOcho.TabIndex = 11;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = false;
            this.btnOcho.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnSiete
            // 
            this.btnSiete.BackColor = System.Drawing.Color.DimGray;
            this.btnSiete.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSiete.Location = new System.Drawing.Point(12, 177);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(62, 46);
            this.btnSiete.TabIndex = 10;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = false;
            this.btnSiete.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.DimGray;
            this.btnResultado.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResultado.Location = new System.Drawing.Point(195, 312);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(62, 46);
            this.btnResultado.TabIndex = 13;
            this.btnResultado.Tag = "=";
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.DimGray;
            this.button14.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button14.Location = new System.Drawing.Point(195, 222);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(62, 46);
            this.button14.TabIndex = 14;
            this.button14.Tag = "-";
            this.button14.Text = "-";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.clickOperador);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.DimGray;
            this.button15.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button15.Location = new System.Drawing.Point(195, 267);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(62, 46);
            this.button15.TabIndex = 15;
            this.button15.Tag = "+";
            this.button15.Text = "+";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.clickOperador);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.DimGray;
            this.button16.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button16.Location = new System.Drawing.Point(195, 177);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(62, 46);
            this.button16.TabIndex = 16;
            this.button16.Tag = "x";
            this.button16.Text = "x";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.clickOperador);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.DimGray;
            this.button17.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button17.Location = new System.Drawing.Point(195, 132);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(62, 46);
            this.button17.TabIndex = 17;
            this.button17.Tag = "/";
            this.button17.Text = "/";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.BackColor = System.Drawing.Color.DimGray;
            this.btnBorrarTodo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTodo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrarTodo.Location = new System.Drawing.Point(134, 87);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(62, 46);
            this.btnBorrarTodo.TabIndex = 18;
            this.btnBorrarTodo.Text = "C";
            this.btnBorrarTodo.UseVisualStyleBackColor = false;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.DimGray;
            this.btnBorrar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrar.Location = new System.Drawing.Point(73, 87);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(62, 46);
            this.btnBorrar.TabIndex = 19;
            this.btnBorrar.Text = "CE";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.DimGray;
            this.btnQuitar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuitar.Location = new System.Drawing.Point(195, 87);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(62, 46);
            this.btnQuitar.TabIndex = 20;
            this.btnQuitar.Text = "<=";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DimGray;
            this.button21.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button21.Location = new System.Drawing.Point(134, 132);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(62, 46);
            this.button21.TabIndex = 21;
            this.button21.Tag = "√";
            this.button21.Text = "√";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.clickOperador);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.DimGray;
            this.button22.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button22.Location = new System.Drawing.Point(73, 132);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(62, 46);
            this.button22.TabIndex = 22;
            this.button22.Tag = "²";
            this.button22.Text = "x²";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.clickOperador);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 46);
            this.button1.TabIndex = 23;
            this.button1.Text = "1/x";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 46);
            this.button2.TabIndex = 24;
            this.button2.Tag = "%";
            this.button2.Text = "%";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.clickOperador);
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(268, 365);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.tbnUno);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.BtnCero);
            this.Controls.Add(this.btnSigno);
            this.Controls.Add(this.txtResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        
        

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSigno;
        private System.Windows.Forms.Button BtnCero;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button tbnUno;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

