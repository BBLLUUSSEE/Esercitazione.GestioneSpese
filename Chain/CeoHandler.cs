using GestioneSpese.Chain;

public class CeoHandler : AbstractHandler
{
    public override string Handle(double richiesta)
    {
        if (richiesta >= 1001 && richiesta <= 2500)
            return $"La spesa è approvata dal CEO";
        else
            return base.Handle(richiesta);
    }
}