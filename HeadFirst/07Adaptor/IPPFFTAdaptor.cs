namespace HeadFirst._07Adaptor;

public class IPPFFTAdaptor: FFTTargetInterface
{
    private IPPFFTAdaptee adaptee;

    public IPPFFTAdaptor(IPPFFTAdaptee adaptee)
    {
        this.adaptee = adaptee;
    }

    public void fft()
    {
        adaptee.computeFFT();
    }

    public void ifft()
    {
        adaptee.computeIFFT();
    }    
}