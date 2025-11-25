public abstract class BaseValidation
{
    public void validateString(string value, string field)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new Exception(field + " cannot be empty.");
        }
    }

    public void validatePrice(double price)
    {
        if (price <= 0)
        {
            throw new Exception("Price must be greater than 0.");
        }
    }
}
