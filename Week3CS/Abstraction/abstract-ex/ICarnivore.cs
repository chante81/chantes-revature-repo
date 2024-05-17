interface ICarnivore
{
    int Value { get; set; }
    // Also assumed to be public



    void EatMeat(); 
    // No need to use public abstract void EatMeat(); for method, because abstract is implied for interfaces
    // Default access modifier in Interfaces is public bc private would not have made sense, so no need to type public

}