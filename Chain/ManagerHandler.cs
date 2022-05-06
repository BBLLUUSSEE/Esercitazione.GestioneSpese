using GestioneSpese.Chain;

public class ManagerHandler : AbstractHandler
{
    public override string Handle(double richiesta)
    {
        if (richiesta <= 400)
            return $"La spesa è approvata dal manager";
        else
            return base.Handle(richiesta);
    }
}