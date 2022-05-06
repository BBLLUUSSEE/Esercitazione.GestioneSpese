using GestioneSpese.Chain;

public class OpManagerHandler : AbstractHandler
{
    public override string Handle(double richiesta)
    {
        if (richiesta >= 401 && richiesta <= 1000)
            return $"La spesa è approvata dall'Operational Manager";
        else
            return base.Handle(richiesta);
    }
}