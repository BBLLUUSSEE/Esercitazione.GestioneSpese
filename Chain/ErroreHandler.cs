using GestioneSpese.Chain;

public class ErroreHandler : AbstractHandler
{
    public override string Handle(double richiesta)
    {
        if (richiesta > 2500)
            return $"La spesa non è approvata";
        else
            return base.Handle(richiesta);
    }
}