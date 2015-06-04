using System;

class Person
{
    private string email;

    public string Name { get; set; }

    public string Age { get; set; }

    public string Email {
        get
        {
            return this.email;
        }
        set
        {
            if (value == null || value.Contains("@"))
            {
                this.email = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid email!");
            }
        }
    }

    public Person(string name, string age) : this(name, age, null)
    {            
    }

    public Person(string name, string age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public override string ToString()
    {
        return string.Format("Name = {0}, Age = {1}, Email = {2}", this.Name, this.Age, this.Email ?? "No email");
    }
}
