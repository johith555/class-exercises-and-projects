using ConsoleApp3.Models;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

internal class CategoryCRUD
{
    private readonly string _cs =
        ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

    public void AddCategory(Category c)
    {
        using SqlConnection con = new(_cs);

        using SqlCommand cmd = new(
            "INSERT INTO Categories (Name) VALUES (@name)", con);

        cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = c.Name;

        con.Open();
        cmd.ExecuteNonQuery();
    }

    public bool UpdateCategory(Category c)
    {
        using SqlConnection con = new(_cs);

        using SqlCommand cmd = new(
            "UPDATE Categories SET Name=@name WHERE Id=@id", con);

        cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = c.Name;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = c.Id;

        con.Open();
        int rows = cmd.ExecuteNonQuery();

        return rows > 0;
    }
    public List<Category> CategoriesList()
    {
        SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);

        SqlDataAdapter da =
            new SqlDataAdapter("SELECT * FROM Categories", con);

        DataTable dt = new DataTable();
        da.Fill(dt);

        List<Category> list = new List<Category>();

        foreach (DataRow dr in dt.Rows)
        {
            Category c = new Category();
            c.Id = Convert.ToInt32(dr["Id"]);
            c.Name = dr["Name"].ToString();

            list.Add(c);
        }

        return list;
    }

}
