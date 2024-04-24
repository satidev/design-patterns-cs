namespace HeadFirst._07Adaptor;

// Target interface.
// Client code only knows about this interface.
public interface FFTTargetInterface
{
    public void fft();
    public void ifft();
}

// Example implementation.
public class MyFft : FFTTargetInterface
{
    public void fft()
    {
        Console.WriteLine("my FFT");
    }

    public void ifft()
    {
        Console.WriteLine("my IFFT");
    }
}