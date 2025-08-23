# Voltage to Laser Power

### Purpose 
The purpose of this workflow is to calibrate laser power with voltage inputs controlled by Bonsai with real-time feedback to be used in wider experimental workflows. 

## Hardware Requirements
- Laser
- Data Acquisition Board
- Power Meter

## Bonsai Workflow

## Properties 

Inputs -
- Laser power from power reading
- Voltage commands
- ExpressionTransform or other transform for conversions and scaling of voltage inputs for desired power outputs


Outputs -
- Voltage outputs for laser power from calibration
- File with voltage inputs and corresponding power inputs

Properties - 
- Wavelength of laser
- Sampling rate
- Min and max voltages 
- Power range

- Could be automated to run through multiple voltages and record corresponding power outputs in real time?