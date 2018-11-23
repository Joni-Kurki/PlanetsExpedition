using System.Collections;
using System.Collections.Generic;

public class Enums {

    public enum BuildingType {
        power = 1,
        science = 2,
        manufactoring = 3,
        livingQuarters = 4,
        warfare = 5,
        healthCare = 6
    }

    public enum PowerConnectionType
    {
        none = 0,
        output = 1,
        input = 2,
        inputEndPoint = 3
    }
}
