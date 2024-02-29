namespace TPDesignPartens.statePatern.view
{
    public interface ICaptureInput
    {
        string CaptureString(string str);
        int CaptureInt(string str,int rangeMin, int rangeMax);


    }
}