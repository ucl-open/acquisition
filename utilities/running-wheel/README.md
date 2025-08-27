# Running Wheel Workflow 

### Purpose
The purpose of this workflow is to track the total distance moved by a running wheel.

## Bonsai Workflow
When this workflow first receives device events from a HARP behavior board, it enables the quadrature encoder and resets the count to zero. It then filters the device events for analog inputs, selects the quadrature encoder output, and converts the output from ticks to distance in centimeters. The distance in centimeters is the final output of the workflow.

<img src="running-wheel.png" alt="workflow" width="400">

## Properties
The properties of this workflow allow the user to define the tick counts per revolution of the encoder, as well as the wheel distance in millimeters. These will be used to convert ticks to distance in centimeters. Note that the Kubler type 05.2400.1122.1024 quadrature encoders encode 1024 counts per revolution, and the HARP board's quadrature counter uses 4x decoding (it counts the rising and falling edge of channel A and channel B), giving a total CountsPerRev of 4096.

### Input and Output `Subjects`
| **Property Name**       | **Input/Output** | **Description**                                                           |
|-------------------------|------------------|---------------------------------------------------------------------------|
| `EventsSubjectName`     | Input            | The name of the subject that receives event messages from the device.     |
| `WheelDistance(cm)`     | Output           | The total distance the wheel has moved, in cm.                            |

### Configuration Parameters
| **Property Name**       | **Input/Output** | **Description**                                                           |
|-------------------------|------------------|---------------------------------------------------------------------------|
| `CountsPerRev`          | Input            | The tick counts per revolution of the wheel.                              |
| `WheelDiameter(mm)`     | Input            | The wheel diameter in millimeters.                                        |

## Dependencies
### Bonsai:
In order to use this module, bonsai must have the following modules installed via the package manager or `Bonsai.config` file.
- [Harp.Behavior](https://www.nuget.org/packages/Harp.Behavior)