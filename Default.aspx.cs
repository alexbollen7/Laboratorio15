using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio15
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGrabar_Click(object sender, EventArgs e)
        {
            List<Producto> productos = new List<Producto>();
            productos = LeerJson();
            Producto producto = new Producto();

            if (productos == null)
            {
                productos = new List<Producto>();
            }
            producto.Descripcion = TextBoxDecripcion.Text;
            string archivo = "~/Imagenes/" + FileUploadImagenes.FileName;
            producto.Imagen = archivo;

            string archivoOrigen = Path.GetFileName(FileUploadImagenes.FileName);

            try
            {
                FileUploadImagenes.SaveAs(Server.MapPath("~/Imagenes/") + archivoOrigen);
                LabelEstado.Text = "Exitosamente subido";
            }
            catch (Exception ex)
            {
                LabelEstado.Text = "No se pudo subir, se generó el siguiente error" + ex;
            }
            productos.Add(producto);

            GuardarJson(productos);
        }

        private void GuardarJson(List<Producto> productos)
        {
            string json = JsonConvert.SerializeObject(productos);
            string archivo = Server.MapPath("Productos.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        private List<Producto> LeerJson()
        {
            List<Producto> lista = new List<Producto>();
            string archivo = System.Web.HttpContext.Current.Server.MapPath("Productos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            if (json == "{}")
            {
                lista = null;
            }
            else
            {
                lista = JsonConvert.DeserializeObject<List<Producto>>(json);
            }

            return lista;
        }
    }
}