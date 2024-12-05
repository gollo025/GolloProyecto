﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Estructuras_No_Lineales.Forms;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void estructurasNoLibealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lISTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListasSimples lista=new ListasSimples();    

            lista.MdiParent=this;

            lista.Show();
        }

        private void sUMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suma miSuma = new Suma();

            miSuma.MdiParent = this;

            miSuma.Show();
        }

        private void eXPONENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exponente miExpo = new Exponente();

            miExpo.MdiParent = this;

            miExpo.Show();
        }

        private void tORRESDEHANOIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Torres miTorre= new Torres();

            miTorre.MdiParent = this;   

            miTorre.Show();
        }

        private void bUSQUEDABUNARIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busqueda miBus = new Busqueda();

            miBus.MdiParent = this;

            miBus.Show();
        }

        private void fACTORIALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factorial miFactorial = new Factorial();    

            miFactorial.MdiParent = this;

            miFactorial.Show();
        }

        private void fIBONACCIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fibonacci fibonacci = new Fibonacci();

            fibonacci.MdiParent = this;

            fibonacci.Show();
        }

        private void pILASToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Pilas pilas = new Pilas();

            pilas.MdiParent = this;

            pilas.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mETODOSDEORDENAMIENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mEZCLANATURALToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bUSQUEDAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cOLASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colas colas = new Colas();

            colas.MdiParent = this;

            colas.Show();
        }

        private void lISTASDOBENCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListasDobles listasDouble = new ListasDobles();
            listasDouble.MdiParent = this;
            listasDouble.Show();
        }

        private void bURBUJAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Burbuja burbuja = new Burbuja();

            burbuja.MdiParent = this;

            burbuja.Show();
        }

        private void qUICKSORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuickSort quickSort = new QuickSort();

            quickSort.MdiParent = this;

            quickSort.Show();
        }

        private void sHELLSORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShellSort shellSort = new ShellSort();  

            shellSort.MdiParent = this;

            shellSort.Show();
        }

        
        private void bUSQUEDAINTERNAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaInterna busquedaInterna = new BusquedaInterna();    

            busquedaInterna.MdiParent = this;

            busquedaInterna.Show();
        }

        private void bUSQUEDASECUENCIALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaSecuencial busquedaSecuencial = new BusquedaSecuencial();

            busquedaSecuencial.MdiParent = this;

            busquedaSecuencial.Show();
        }

        private void bUSQUEDAHASHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lISTASCIRCSIMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
