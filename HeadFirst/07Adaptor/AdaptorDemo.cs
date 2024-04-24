namespace HeadFirst._07Adaptor;

public class AdaptorDemo
{
    public static void ClientCode()
    {
        MyFft myFft = new MyFft();
        myFft.fft();
        myFft.ifft();
        
        // Adaptee
        IPPFFTAdaptee adaptee = new IPPFFTAdaptee();
        // Adaptor
        IPPFFTAdaptor adaptor = new IPPFFTAdaptor(adaptee);
        // Client
        adaptor.fft();
        adaptor.ifft();
    }
}