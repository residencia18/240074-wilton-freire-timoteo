object o = null;

try
{
    o.ToString();
}
catch (NullReferenceException ex)
{
    throw new Exception("Não é possível chamar o método ToString() em um objeto nulo. Verifique se o objeto é válido antes de chamar este método.", ex);
}

//Tipo de exceção: Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.