using HeladeriaAPI.Models.Dto;
using Newtonsoft.Json;
using System.Text;

namespace Heladeria
{
    public partial class frmHeladeria : Form
    {
        private static int id = 0;
        private static int ig = 0;
        private static int iz = 0;
        private static decimal suma = 0;
        public frmHeladeria()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmHeladeria_Load(object sender, EventArgs e)
        {
            GetAllHelados();
            GetAllToppings();
            GetAllVentas();
            UpdateComboboxHelado();
            UpdateComboboxTopping();
        }

        private async void UpdateComboboxTopping()
        {
            cmdTopping.Items.Clear();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7219/api/Toppings"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var topping = await response.Content.ReadAsStringAsync();
                        var displaydata = JsonConvert.DeserializeObject<List<ToppingsDto>>(topping);
                        foreach (ToppingsDto Gelado in displaydata)
                        {
                            cmdTopping.Items.Add(Gelado.Topping);
                        }
                    }
                }
            }
        }

        private async void UpdateComboboxHelado()
        {
            cmbHelados.Items.Clear();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7219/api/Helado"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var helado = await response.Content.ReadAsStringAsync();
                        var displaydata = JsonConvert.DeserializeObject<List<HeladoDto>>(helado);
                        foreach (HeladoDto Gelado in displaydata)
                        {
                            cmbHelados.Items.Add(Gelado.NombreHelado);
                        }
                    }
                }
            }
        }

        private async void GetAllVentas()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7219/api/Ventas"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ventas = await response.Content.ReadAsStringAsync();
                        var displaydata = JsonConvert.DeserializeObject<List<ToppingsDto>>(ventas);
                        dgvDatos_Topping.DataSource = displaydata.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de Toppings: {response.StatusCode}");
                    }
                }
            }
        }

        private async void GetAllToppings()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7219/api/Toppings"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var topping = await response.Content.ReadAsStringAsync();
                        var displaydata = JsonConvert.DeserializeObject<List<ToppingsDto>>(topping);
                        dgvDatos_Topping.DataSource = displaydata.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de Toppings: {response.StatusCode}");
                    }
                }
            }
        }
        private async void GetAllHelados()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7219/api/Helado"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var helado = await response.Content.ReadAsStringAsync();
                        var displaydata = JsonConvert.DeserializeObject<List<HeladoDto>>(helado);
                        dgvDatos_Helados.DataSource = displaydata.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de Helados: {response.StatusCode}");
                    }
                }
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddHelado();
        }

        private async void AddHelado()
        {
            HeladoCrearDto oHelado = new HeladoCrearDto();
            oHelado.NombreHelado = txtNombre_Helado.Text;
            oHelado.PrecioHelado = decimal.Parse(txtPrecio_Helado.Text);
            oHelado.CantidadHelado = decimal.Parse(txtCantidad_Helado.Text);
            using (var client = new HttpClient())
            {
                var serializedHelado = JsonConvert.SerializeObject(oHelado);
                var content = new StringContent(serializedHelado, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7219/api/Helado", content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Helado agregado");
                else
                    MessageBox.Show($"Error al guardar el Helado: {response.Content.ReadAsStringAsync().Result}");
            }
            Clear_Helados();
            GetAllHelados();
        }

        private void Clear_Helados()
        {
            txtNombre_Helado.Text = string.Empty;
            txtCantidad_Helado.Text = string.Empty;
            txtPrecio_Helado.Text = string.Empty;
            txtId_Helado.Text = string.Empty;
            id = 0;
        }

        private void btnAgregar_Topping_Click(object sender, EventArgs e)
        {
            AddTopping();
        }

        private async void AddTopping()
        {
            ToppingsCrearDto oTopping = new ToppingsCrearDto();
            oTopping.Topping = txtNombre_Topping.Text;
            oTopping.CantidadToppings = int.Parse(txtCantidad_Topping.Text);
            oTopping.PrecioTopping = decimal.Parse(txtPrecio_Topping.Text);
            using (var client = new HttpClient())
            {
                var serializedTopping = JsonConvert.SerializeObject(oTopping);
                var content = new StringContent(serializedTopping, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7219/api/Topping", content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Topping agregado");
                else
                    MessageBox.Show($"Error al guardar el Topping: {response.Content.ReadAsStringAsync().Result}");
            }
            Clear_Toppings();
            GetAllToppings();
        }

        private void Clear_Toppings()
        {
            txtNombre_Topping.Text = string.Empty;
            txtCantidad_Topping.Text = string.Empty;
            txtPrecio_Topping.Text = string.Empty;
            txtId_Topping.Text = string.Empty;
            id = 0;
        }

        private void btnAgregar_Ventas_Click(object sender, EventArgs e)
        {
            AddVentas();

        }

        private async void AddVentas()
        {

            GetHeladosByName(cmbHelados.Items[cmbHelados.SelectedIndex]);
            GetToppingByName(cmdTopping.Items[cmdTopping.SelectedIndex]);
            GetIngresosTotales();
            VentasCrearDto oVentas = new VentasCrearDto();
            oVentas.IdToppings = iz;
            oVentas.IdHelado = ig;
            oVentas.IngresosDeVenta = suma;


            using (var client = new HttpClient())
            {
                var serializedTopping = JsonConvert.SerializeObject(oVentas);
                var content = new StringContent(serializedTopping, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7219/api/Ventas", content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Venta agregado");
                else
                    MessageBox.Show($"Error al guardar la Venta: {response.Content.ReadAsStringAsync().Result}");
            }
            Clear_Ventas();
            GetAllVentas();
        }

        private async void GetIngresosTotales()
        {
            decimal x = 0;
            decimal y = 0;
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7219/api/Helado", ig));
                if (response.IsSuccessStatusCode)
                {
                    var helado = await response.Content.ReadAsStringAsync();
                    HeladoDto heladoDto = JsonConvert.DeserializeObject<HeladoDto>(helado);
                    x = heladoDto.PrecioHelado * nudHelado.Value;
                    lblTotal_Helado.Text = x.ToString();

                    heladoDto.CantidadHelado = heladoDto.CantidadHelado - nudHelado.Value;
                    helado = JsonConvert.SerializeObject(heladoDto);
                    var content = new StringContent(helado, Encoding.UTF8, "application/json");
                    response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7219/api/Helado", ig), content);

                }
            }
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7219/api/Toppings", iz));
                if (response.IsSuccessStatusCode)
                {
                    var topping = await response.Content.ReadAsStringAsync();
                    ToppingsDto toppingDto = JsonConvert.DeserializeObject<ToppingsDto>(topping);
                    y = toppingDto.PrecioTopping * nudTopping.Value;
                    lblTotal_Topping.Text = y.ToString();

                    toppingDto.CantidadToppings = toppingDto.CantidadToppings - Convert.ToInt32(nudTopping.Value);
                    topping = JsonConvert.SerializeObject(toppingDto);
                    var content = new StringContent(topping, Encoding.UTF8, "application/json");
                    response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7219/api/Toppings", iz), content);
                }
            }
            suma = y + x;
        }

        private async void GetHeladosByName(object v)
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7219/api/Helado"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var helado = await response.Content.ReadAsStringAsync();
                        var displaydata = JsonConvert.DeserializeObject<List<HeladoDto>>(helado);
                        foreach (HeladoDto Gelado in displaydata)
                        {
                            if (Gelado.NombreHelado == v)
                            {
                                ig = Gelado.IdHelado;
                            }
                        }
                    }
                }
            }

        }

        private async void GetToppingByName(object v)
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7219/api/Toppings"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var topping = await response.Content.ReadAsStringAsync();
                        var displaydata = JsonConvert.DeserializeObject<List<ToppingsDto>>(topping);
                        foreach (ToppingsDto Gelado in displaydata)
                        {
                            if (Gelado.Topping == v)
                            {
                                iz = Gelado.IdToppings;
                            }
                        }
                    }
                }
            }
        }

        private void Clear_Ventas()
        {

            txtId_Ventas.Text = string.Empty;
            id = 0;
        }

        private void dgvDatos_Helados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvDatos_Helados.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    GetHeladosById(id);
                }
            }
        }

        private async void GetHeladosById(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7219/api/Helado", id));
                if (response.IsSuccessStatusCode)
                {
                    var helado = await response.Content.ReadAsStringAsync();
                    HeladoDto heladoDto = JsonConvert.DeserializeObject<HeladoDto>(helado);
                    txtId_Helado.Text = heladoDto.IdHelado.ToString();
                    txtNombre_Helado.Text = heladoDto.NombreHelado;
                    txtCantidad_Helado.Text = heladoDto.CantidadHelado.ToString();
                    txtPrecio_Helado.Text = heladoDto.PrecioHelado.ToString();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener el Helado: {response.StatusCode}");
                }
            }
        }

        private void dgvDatos_Topping_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvDatos_Topping.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    GetToppingsById(id);
                }
            }
        }

        private async void GetToppingsById(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7219/api/Toppings", id));
                if (response.IsSuccessStatusCode)
                {
                    var topping = await response.Content.ReadAsStringAsync();
                    ToppingsDto toppingDto = JsonConvert.DeserializeObject<ToppingsDto>(topping);
                    txtId_Topping.Text = toppingDto.IdToppings.ToString();
                    txtNombre_Topping.Text = toppingDto.Topping;
                    txtCantidad_Topping.Text = toppingDto.CantidadToppings.ToString();
                    txtPrecio_Topping.Text = toppingDto.PrecioTopping.ToString();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener el Topping: {response.StatusCode}");
                }
            }
        }

        private void btnModificar_Helado_Click(object sender, EventArgs e)
        {
            if (id != 0)
                UpdateHelado();
        }

        private async void UpdateHelado()
        {
            HeladoUpdateDto heladoDto = new HeladoUpdateDto();
            heladoDto.IdHelado = id;
            heladoDto.NombreHelado = txtNombre_Helado.Text;
            heladoDto.PrecioHelado = decimal.Parse(txtPrecio_Helado.Text);
            heladoDto.CantidadHelado = decimal.Parse(txtCantidad_Helado.Text);

            using (var client = new HttpClient())
            {
                var helado = JsonConvert.SerializeObject(heladoDto);
                var content = new StringContent(helado, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7219/api/Helado", id), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Helado actualizado");
                else
                    MessageBox.Show($"Error al actualizar el Helado: {response.StatusCode}");
            }
            Clear_Helados();
            GetAllHelados();
        }

        private void btnModificar_Topping_Click(object sender, EventArgs e)
        {
            if (id != 0)
                UpdateTopping();
        }

        private async void UpdateTopping()
        {
            ToppingsUpdateDto toppingDto = new ToppingsUpdateDto();
            toppingDto.IdToppings = id;
            toppingDto.Topping = txtNombre_Topping.Text;
            toppingDto.PrecioTopping = decimal.Parse(txtPrecio_Topping.Text);
            toppingDto.CantidadToppings = int.Parse(txtCantidad_Topping.Text);

            using (var client = new HttpClient())
            {
                var topping = JsonConvert.SerializeObject(toppingDto);
                var content = new StringContent(topping, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7219/api/Toppings", id), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Topping actualizado");
                else
                    MessageBox.Show($"Error al actualizar el Topping: {response.StatusCode}");
            }
            Clear_Toppings();
            GetAllToppings();
        }

        private void btnBorrar_Helado_Click(object sender, EventArgs e)
        {
            if (id != 0)
                DeleteHelado(id);
        }

        private async void DeleteHelado(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7219/api/Helado");
                var response = await client.DeleteAsync(String.Format("{0}/{1}",
                    "https://localhost:7219/api/Helado", id));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Helado eliminado con éxito");
                else
                    MessageBox.Show($"No se pudo eliminar el Helado: {response.StatusCode}");
            }
            Clear_Helados();
            GetAllHelados();
        }

        private void btnBorrar_Topping_Click(object sender, EventArgs e)
        {
            if (id != 0)
                DeleteTopping(id);
        }

        private async void DeleteTopping(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7219/api/Toppings");
                var response = await client.DeleteAsync(String.Format("{0}/{1}",
                    "https://localhost:7219/api/Toppings", id));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Topping eliminado con éxito");
                else
                    MessageBox.Show($"No se pudo eliminar el Topping: {response.StatusCode}");
            }
            Clear_Toppings();
            GetAllToppings();
        }

        private void btnLimpiar_Helado_Click(object sender, EventArgs e)
        {
            Clear_Helados();
        }

        private void btnLimpiar_Topping_Click(object sender, EventArgs e)
        {
            Clear_Toppings();
        }

        private void btnModificar_Ventas_Click(object sender, EventArgs e)
        {
            if (id != 0)
                UpdateVentas();
        }

        private async void UpdateVentas()
        {
            GetHeladosByName(cmbHelados.Items[cmbHelados.SelectedIndex]);
            GetToppingByName(cmdTopping.Items[cmdTopping.SelectedIndex]);
            GetIngresosTotales();
            VentasUpdateDto oVentas = new VentasUpdateDto();
            oVentas.IdToppings = iz;
            oVentas.IdHelado = ig;
            oVentas.IngresosDeVenta = suma;
            using (var client = new HttpClient())
            {
                var ventas = JsonConvert.SerializeObject(oVentas);
                var content = new StringContent(ventas, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7219/api/Ventas", id), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Venta actualizado");
                else
                    MessageBox.Show($"Error al actualizar la Venta: {response.StatusCode}");
            }
            Clear_Ventas();
            GetAllVentas();
        }

        private void dgvDatos_Ventas_Click(object sender, EventArgs e)
        {

        }

        private void dgvDatos_Ventas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvDatos_Ventas.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    GetVentasById(id);
                }
            }
        }

        private async void GetVentasById(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7219/api/Ventas", id));
                if (response.IsSuccessStatusCode)
                {
                    var ventas = await response.Content.ReadAsStringAsync();
                    VentasDto ventasDto = JsonConvert.DeserializeObject<VentasDto>(ventas);
                    txtId_Ventas.Text = ventasDto.Id.ToString();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener el Helado: {response.StatusCode}");
                }
            }
        }

        private void btnLimpiar_Ventas_Click(object sender, EventArgs e)
        {
            Clear_Ventas();
        }

        private void btnBorrar_Ventas_Click(object sender, EventArgs e)
        {
            if (id != 0)
                DeleteVentas(id);
        }

        private async void DeleteVentas(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7219/api/Ventas");
                var response = await client.DeleteAsync(String.Format("{0}/{1}",
                    "https://localhost:7219/api/Ventas", id));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Venta eliminada con éxito");
                else
                    MessageBox.Show($"No se pudo eliminar la Venta: {response.StatusCode}");
            }
            Clear_Ventas();
            GetAllVentas();
        }
    }
}