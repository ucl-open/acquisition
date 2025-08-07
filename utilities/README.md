# Utilities

Workflow "modules" that interface with hardware components. Examples could include camera acquisition, reward delivery, etc.

## Adding New Hardware Modules

To add a new hardware module to this repository:

1. **Create a folder** with a descriptive name (e.g., `camera-acquisition`, `reward-delivery`)
2. **Add a README.md** file in the folder that includes:
   - Screenshot of the workflow
   - The hardware (with links)
   - The inputs and outputs (and any assumed connection-pins etc.)
   - Any user-parameters that need to be input (and their defaults)
   - Output file specifications
3. **Include the workflow file(s)** (.bonsai files)
4. **Add any configuration files** needed for the hardware module
5. **Test the hardware module** with actual hardware before committing
