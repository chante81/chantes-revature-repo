namespace VehicleAPI.Models;

public class Vehicle
{
    public int VehicleId {get;set;}
    public string Make {get;set;}
    public string Model {get;set;}
    public int VehicleYear {get;set;}
    public bool NeedsMaintenance {get;set;}

    public Vehicle(int VehicleId, string Make, string Model, int VehicleYear, bool NeedsMaintenance)
    {
        this.VehicleId = VehicleId;
        this.Make = Make;
        this.Model = Model;
        this.VehicleYear = VehicleYear;
        this.NeedsMaintenance = NeedsMaintenance;
    }

}