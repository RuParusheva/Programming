using System;

public class Student : ICloneable, IComparable
{
    protected string FirstName { get; set; }
    protected string MiddleName { get; set; }
    protected string LastName { get; set; }
    protected string SSN { get; set; }
    protected string PermanentAddress { get; set; }
    protected string MobilePhone { get; set; }
    protected string EMail { get; set; }
    protected string Course { get; set; }
    protected Specialty Specialty { get; set; }
    protected Faculty Faculty { get; set; }
    protected University University { get; set; }

    public Student(string firstName, string middleName, string lastName, string ssn, string permanentAddress,
        string eMail)
        : this(
            firstName, middleName, lastName, ssn, permanentAddress, null, eMail, null, Specialty.Unknown,
            Faculty.Unknown, University.Unknown)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.SSN = ssn;
        this.PermanentAddress = permanentAddress;
        this.EMail = eMail;
    }

    public Student(string firstName, string middleName, string lastName, string ssn, string permanentAddress,
        string mobilePhone, string eMail, string course, Specialty specialty, Faculty faculty, University university)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.SSN = ssn;
        this.PermanentAddress = permanentAddress;
        this.MobilePhone = mobilePhone;
        this.EMail = eMail;
        this.Course = course;
        this.Specialty = specialty;
        this.Faculty = faculty;
        this.University = university;
    }

    public override string ToString()
    {
        return
            string.Format("My name is {0} {1} {2}. Personal information provided: \nSSN: {3};\nPermanent address: {4};\nMobile phone: {5}; \nE-mail address: {6}; \nI am in {7} course and study {8}, part of Faculty {9} at {10}",
                this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress, this.MobilePhone,
                this.EMail, this.Course,
                this.Specialty, this.Faculty, this.University);

    }

    public override bool Equals(object obj)
    {
        if (!(obj is Student))
        {
            return false;
        }

        Student student = obj as Student;

        if (this.SSN != student.SSN)
        {
            return false;
        }

        return true;
    }

    public override int GetHashCode()
    {
        return SSN.GetHashCode() ^ PermanentAddress.GetHashCode();
    }

    public int CompareTo(object other)
    {
        if (other == null)
        {
            return 1;
        }

        Student otherStudent = other as Student;

        if (this.FirstName.CompareTo(otherStudent.FirstName) != 0)
        {
            return this.FirstName.CompareTo(otherStudent.FirstName);
        }

        if (this.MiddleName.CompareTo(otherStudent.MiddleName) != 0)
        {
            return this.MiddleName.CompareTo(otherStudent.MiddleName);
        }

        if (this.LastName.CompareTo(otherStudent.LastName) != 0)
        {
            return this.LastName.CompareTo(otherStudent.LastName); 
        }

        if (this.SSN.CompareTo(otherStudent.SSN) != 0)
        {
            return this.SSN.CompareTo(otherStudent.SSN);
        }

        return 0;
    }

    public object Clone()
    {
        return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress, this.MobilePhone,
                this.EMail, this.Course,
                this.Specialty, this.Faculty, this.University);
    }

    public static bool operator ==(Student student1, Student student2)
    {
        return Student.Equals(student1, student2);
    }

    public static bool operator !=(Student student1, Student student2)
    {
        return !(Student.Equals(student1, student2));
    }
}
