# Audio-Visual lag calibration workflow

### Purpose 
This workflow is used to measure the response time of the Auditory and Visual stimuli once the command is send by the computer. The measured relative lag between those is then compensated while running Experiments. 

## Hardware Requirements
- Projector (or Monitor)
- Photodiode (for visual stimuli)
- Exp. controll board (to threshold Photodiode)
- Speakers
- Microphone (or alt. feeding speaker signal directly into DAQ)
- Harp.Behaviour board or NI-DAQ

## Bonsai Workflow
- TBD

## Properties 
Setting up - 
- position photodiode and set threshold that reliably switched of On/Off of visual stimuli
- position microphone or alt. wire speaker signal to DAQ

Inputs -

Outputs -
- Response lag for Auditory and Visual stimuli
- relative difference between both in a cenvenien format (calibration csv file) to be loaded by the setup while running
