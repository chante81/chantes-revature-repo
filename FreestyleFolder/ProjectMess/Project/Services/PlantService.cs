using System.Data.Common;

class PlantService
{
    /*
        Services Needed for Plants:
        - Get All Available plants
        - Get One plant
        - Buy plant
        - Get Purchase History per buyer
    */
    NPlantRepo pr;

    public PlantService(NPlantRepo pr)
    {
        this.pr = pr;
    }

    public List<Plant> GetAvailablePlants()
    {
        // Create list of all plants by calling GetAllPlants method
        List<Plant> allPlants = pr.GetAllPlants();
        // Create empty List for available plants
        List<Plant> availablePlants = new();
        // Loop through allPlants list to find available plants and add to new availablePlants list.
        foreach (Plant p in allPlants)
        {
            if (p.Available)
            {
                availablePlants.Add(p);
            }
        }

        //Return that list of available plants.
        return availablePlants;
    }

    // trivial service calling GetPlant method - already set up to get one plant, no need to edit.
    public Plant? GetPlant(int id)
    {
        return pr.GetPlant(id);
    }

    public Plant BuyPlant(Plant p, User u)
    {
        if (!p.Available)
        {
            Console.WriteLine("Selected Plant is Not Available. Please try again.");
#pragma warning disable CS8603 // Possible null reference return.
            return null;
#pragma warning restore CS8603 // Possible null reference return.
        }
        p.Available = false;
        p.UserId = u.UserId;
        return p;
    }

    public List<Plant> PurchaseHistory(User u)
    {
        // Create list of all plants by calling GetAllPlants method 
        List<Plant> allPlants = pr.GetAllPlants();
        // Create empty List for buyer's plants
        List<Plant> buyersPlants = new();
        foreach (Plant p in allPlants)
        {
            if (p.UserId == u.UserId)
            {
                buyersPlants.Add(p);
            }
            // else
            // {
            //     System.Console.WriteLine("There are no items here.");
            //     return null;
            // }
        }
        if (buyersPlants.Count == 0) 
        {
            System.Console.WriteLine("There are no items here.");
        }
        return buyersPlants;

    }

    public Plant? UpdatePlant(Plant p)
    {
        return pr.UpdatePlant(p);
    }

}