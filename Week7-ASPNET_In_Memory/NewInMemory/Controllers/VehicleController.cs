using Microsoft.AspNetCore.Mvc;
using VehicleAPI.Models;

namespace VehicleAPI.Controllers;

[ApiController]

[Route("[controller]")] // http://localholst:port/Vehicle  "controller" to the left is what's cut off from below class
public class VehicleController : ControllerBase
{
    /*
    This controller will receive HTTP requests to the path /Vehicle
    Based on the HTTP Method it receives, it will direct the request to different "Actions" Methods in controllers are called Actions
    */

    public static List<Vehicle> Vehicles = new List<Vehicle>
{
    new(1, "Toyota", "Camry", 2010, false),
    new(2, "Honda", "CRV", 2020, false),
    new(3, "Subaru", "Outback", 2012, true),
    new(4, "Dodge", "Challenger", 2018, false),
    new(5, "Ford", "F150", 2008, true),
    new(6, "Acura", "MDX", 2022, false)
};


    // GET all vehicles

    // This is the beginning part of a GET action to the path /Vehicle
    // You need this to let the controller know that this method should be called when a GET request is sent to /Vehicle
    [HttpGet]
    public IActionResult GetVehicles()
    {
        return Ok(Vehicles);
    }

    // GET a vehicle by ID
    // This is expectin the client to send GET request to /Vehicle and also provice a /Id
    // This Id needs to be an integer
    // example
    // http//localhost:port/Vehicle/1
    // http//localhost:port/Vehicle/39933
    // http//localhost:port/Vehicle/1324


    // http//localhost:port/12/Vehicle
    [HttpGet("{Id}")]
    public IActionResult GetVehicleById(int Id)
    {
        // This is an example of functional programming 
        // we have an array and we want to fileter through that array and grab the first thing that matches the correct Id
        // We have created a LINQ onto the Vehicled array that will filter through each of the vehicles and check to see if the VehicleId matches
        // the Id that was passed in
        // If it matches, then it will return that vehicle
        // Vehicle vehicle = Vehicles.Find(v => v.VehicleId == Id);
        // return Ok(vehicle);

        foreach (Vehicle vehicle in Vehicles)
        {
            if (vehicle.VehicleId == Id)
            {
                return Ok(vehicle);
            }
        }
        return NotFound();
    }

    // POST a new vehicle
    [HttpPost]
    public IActionResult PostVehicle(Vehicle vehicle)
    {
        vehicle.VehicleId = Vehicles.Count + 1;
        Vehicles.Add(vehicle);
        return Ok();
    }

    // PUT a new update on an existing vehicle
    [HttpPut("{Id}")]
    public IActionResult PutVehicle(int Id, Vehicle updatedVehicle)
    {
        int index = Vehicles.FindIndex(v => v.VehicleId == Id);
        Vehicles[index] = updatedVehicle;

        return Ok();
    }

    // DELETE an existing vehicle
    [HttpDelete("{Id}")]
    public IActionResult DeleteVehicle(int Id)
    {
        foreach (Vehicle vehicle in Vehicles)
        {
            if (vehicle.VehicleId == Id)
            {
                Vehicles.Remove(vehicle);
                return Ok(vehicle);
            }
        }
        return NotFound();
    }


}
