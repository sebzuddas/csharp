static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        // defaults when returning null

        if (id != null && department != null) // if id and department exist
        {
            department = department.ToUpper();
            return $"[{id}] - {name} - {department}"; 
        }
        else if (id != null) // if department is null and id exists
        {
            string result = department ?? "OWNER"; // return owner
            return $"[{id}] - {name} - {result}";
        }
        else if (department != null) // if id is null and department exists
        {
            department = department.ToUpper();
            return $"{name} - {department}";

        }
        else // if id and department don't exist (are null)
        {
            return $"{name} - OWNER";

        }
    }
}
