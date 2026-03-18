using ConsoleApp3.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace ConsoleApp3.CRUD
{
    internal class ProductCrud
    {
        string cs = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();

        public string AddProduct(Product product)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "insert into products(name,categId) values (@name,@categId)", con);

                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@categId", product.CategId);

                con.Open();
                cmd.ExecuteNonQuery();

                return "Product Added Successfully";
            }
        }

        public string UpdateProduct(Product p)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "update products set name=@name, categId=@categId where id=@id", con);

                cmd.Parameters.AddWithValue("@name", p.Name);
                cmd.Parameters.AddWithValue("@categId", p.CategId);
                cmd.Parameters.AddWithValue("@id", p.Id);

                con.Open();
                cmd.ExecuteNonQuery();

                return "Product Updated Successfully";
            }
        }

        public string DeleteProduct(int id)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd =
                    new SqlCommand("delete from products where id=@id", con);

                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();

                return "Product Deleted Successfully";
            }
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select * from products", con);
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    products.Add(new Product
                    {
                        Id = Convert.ToInt32(dr["id"]),
                        Name = dr["name"].ToString(),
                        CategId = Convert.ToInt32(dr["categId"])
                    });
                }
            }

            return products;
        }
    }
}
