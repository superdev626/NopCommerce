using Nop.Web.Framework.Models;

namespace Nop.Web.Models.Vehicles
{
    public partial record VehicleModel : BaseNopEntityModel
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

}