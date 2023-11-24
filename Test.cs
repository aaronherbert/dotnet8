using AutoMapper;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;
using Rectangle = (ThingMaker service, Moq.Mock<AutoMapper.IMapper> mapper, Moq.Mock<Microsoft.Extensions.Logging.ILogger<ThingMaker>> logger);
 

public class Tests
{
    private static (ThingMaker, Mock<IMapper>, Mock<ILogger<ThingMaker>>) Setup()
    {
        var mockMapper = new Mock<IMapper>();
        var mockLogger = new Mock<ILogger<ThingMaker>>();
        var service = new ThingMaker(mockMapper.Object, mockLogger.Object);
        return (service, mockMapper, mockLogger);
    }

    [Fact]
    public static void Works()
    {
        Rectangle service = Setup();
        
       
    }

}


public class ThingMaker
{
    public ThingMaker(IMapper mapper, ILogger<ThingMaker> logger)
    {
        
    }


}