using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HINVenture.Shared.Models.ViewModels
{
    class OrderEditViewModel
    {
		public int orderId { get; set; }
		public string Description { get; set; }
		[Required(ErrorMessage = "Title must have a name")]
		public string Name { get; set; }

		[DataType(DataType.Currency)]
		[Required(ErrorMessage = "Price must be numerical")]
		public decimal Price { get; set; }
	}
}
