# Live Sleap Tracking Workflow 

### Purpose
The purpose of this workflow is to do live Sleap tracking of animal poses.

## Bonsai Workflow
This workflow accepts a pre-trained Sleap model and a video stream as input and ouputs the x position, y position, and confidence of each model body part for each frame.

<img src="sleap-tracking.png" alt="workflow" width="400">

## Properties
The properties of this workflow allow the user to provide the path to their pre-trained model and config files. 

### Input and Output `Subjects`
| **Property Name**       | **Input/Output** | **Description**                                                           |
|-------------------------|------------------|---------------------------------------------------------------------------|
| `CameraFrames`          | Input            | The stream of image frames.                                               |
| `MouseBodyParts`        | Output           | The frame, body part name, x pos, y pos, and confidence of each body part at each frame.                       |

### Configuration Parameters
| **Property Name**       | **Input/Output** | **Description**                                                           |
|-------------------------|------------------|---------------------------------------------------------------------------|
| `ModelFileName`         | Input            | The path to the frozen_graph.pb file.                                     |
| `TrainingConfig`        | Input            | The path to the training config JSON file.                                |

## Dependencies
### Bonsai:
In order to use this module, Bonsai must have the following modules installed via the package manager or 'Bonsai.config' file.
- [Sleap](https://www.nuget.org/packages/Bonsai.Sleap)
- [Sleap.Design](https://www.nuget.org/packages/Bonsai.Sleap.Design)