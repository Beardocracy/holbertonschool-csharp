using System;

public enum Rating
{
    Good,
    Great,
    Excellent
}

public struct Dog
{
    public Dog(string nameC, float ageC, string ownerC, Rating ratingC)
    {
        name = nameC;
        age = ageC;
        owner = ownerC;
        rating = ratingC;
    }

    public string name { get; }
    public float age { get; }
    public string owner { get; }
    public Rating rating { get; }
}