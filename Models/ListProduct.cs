using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moldovan_Luminita_Lab7.Models
{
 public class ListProduct
 {
 [PrimaryKey, AutoIncrement]
 public int ID { get; set; }
 public int ShopListID { get; set; }
 public int ProductID { get; set; }
 } 
}
