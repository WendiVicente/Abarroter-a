using CapaDatos.Data;
using CapaDatos.ListasPersonalizadas;
using CapaDatos.Repository;
using CapaDatos.Validation;
using ComponentFactory.Krypton.Toolkit;
using sharedDatabase.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sistema.Forms.modulo_producto
{
    public partial class CategoriaProducto : BaseContext
    {
        private CategoriaProdRepository _categoriaRepository = null;
        private int estadoCategoria = 0;
        byte[] icono = null;

        public CategoriaProducto()
        {
            InitializeComponent();            
        }

        private void CategoriaProducto_Load(object sender, EventArgs e)
        {
            RefrescarDataGrid();
        }

        public void RefrescarDataGrid(bool LoadNewContext = true)
        {
            if (LoadNewContext)
            {
                _context = null;
                _context = new Context();
                _categoriaRepository = null;
                _categoriaRepository = new CategoriaProdRepository(_context);
            }

            var listaTipos = _categoriaRepository.GetListcategoria();
            BindingSource source = new BindingSource();
            source.DataSource = listaTipos;
            dgvCategorias.DataSource = typeof(List<>);
            dgvCategorias.DataSource = source;

        }

        private void lbcatelimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxtcategorias();
            estadoCategoria = 0;
        }

        private void checkestadocate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarCate_Click(object sender, EventArgs e)
        {
            GuardarCategoria();
            LimpiarTxtcategorias();
        }

        private void btnActualizarCate_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                return;
            }
            if (estadoCategoria == 1)
            {
                var tipoRow = (ListarCategoriaProd)dgvCategorias.CurrentRow.DataBoundItem;
                var GetCateg = _categoriaRepository.GetCategoria(tipoRow.Id);

                var modeloEditar = GetmodeloCategoria(GetCateg);
                if (String.IsNullOrEmpty(txtcategoria.Text)) { KryptonMessageBox.Show("Campo Vacio, ingresar una categoria"); return; }
                if (!ModelState.IsValid(modeloEditar)) { return; }

                _categoriaRepository.Update(modeloEditar);

                RefrescarDataGrid(true);
                LimpiarTxtcategorias();
            }
        }        

        private Categoria GetmodeloCategoria(Categoria categoria)
        {
            categoria.Nombre = txtcategoria.Text;
            categoria.Inactivo = checkestadocate.Checked;
            categoria.Imagen = icono;
            return categoria;
        }

        private Categoria GetmodeloNewCategoria()
        {
            return new Categoria()
            {
                Nombre = txtcategoria.Text,
                Inactivo = checkestadocate.Checked,
                Imagen = icono
            };


        }
        //************* fin 

        private void GuardarCategoria()
        {
            if (estadoCategoria == 0)
            {
                var modeloCategoria = GetmodeloNewCategoria();
                if (String.IsNullOrEmpty(txtcategoria.Text)) { KryptonMessageBox.Show("Campo Vacio, ingresar una nueva categoria"); return; }
                if (!ModelState.IsValid(modeloCategoria)) { return; }

                _categoriaRepository.Add(modeloCategoria);

                RefrescarDataGrid(true);
            }
        }

        public void LlenarTextBoxCategoria(int IndiceDGV)
        {
            var categoria = (ListarCategoriaProd)dgvCategorias.Rows[IndiceDGV].DataBoundItem;
            LbIdCat.Text = categoria.Id.ToString();
            txtcategoria.Text = categoria.Categoria.ToString();
            SetImagen(categoria.Imagen);
            if (categoria.Estado == "Activa")
            {
                checkestadocate.Checked = false;
            }
            else
            {
                checkestadocate.Checked = true;
            }
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarTextBoxCategoria(dgvCategorias.CurrentRow.Index);
            lbcatelimpiar.Visible = true;
            estadoCategoria = 1;
        }

        private void LimpiarTxtcategorias()
        {
            LbIdCat.Text = "";
            txtcategoria.Text = "";
            checkestadocate.Checked = false;
            PbIcono.Image = Sistema.Properties.Resources.anadir_imagen32;
            PbIcono.SizeMode = PictureBoxSizeMode.CenterImage;
            estadoCategoria = 0;
        }        

        private void BtnIcono_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagen = new OpenFileDialog();
            imagen.Filter = "Archivos png(*.png)|*.png| Archivos JPG (*.jpg)|*.jpg";
            DialogResult filestream = imagen.ShowDialog();
            if (filestream == DialogResult.OK)
            {
                PbIcono.Image = Image.FromFile(imagen.FileName);
                PbIcono.SizeMode = PictureBoxSizeMode.Zoom;
                filestreamImagen();
            }
        }

        private void filestreamImagen()
        {
            icono = null;
            MemoryStream memoryStream = new MemoryStream();
            PbIcono.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            memoryStream.GetBuffer();
            icono = memoryStream.GetBuffer();
        }

        private void SetImagen(byte[] icon)
        {
            if (icon != null)
            {
                icono = icon;
                MemoryStream mStream = new MemoryStream(icono);
                PbIcono.Image = Image.FromStream(mStream);
                PbIcono.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
