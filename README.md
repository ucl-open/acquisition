# bonsai-workflows

This repository contains Bonsai workflows organized into three main categories:

## Repository Structure

### 📋 [Protocols](./protocols/)
Workflows specific to individual behavioural protocols, or general protocol structures used in the lab. Examples include AFC tasks, passive stimulus presentations, etc.

### 🔧 [Calibrations](./calibrations/)
Standalone calibration workflows such as gamma-calibration, laser-power-calibration, etc.

### ⚙️ [Utilities](./utilities/)
Workflow "modules" that interface with hardware components. Examples include camera acquisition, reward delivery, etc.

## General Guidelines

When adding new workflows to any category:

1. **Create a folder** with a descriptive name
2. **Add a README.md** file in the folder that includes:
   - Screenshot of the workflow
   - Clear description and purpose
   - Hardware requirements (if applicable)
   - Usage instructions
   - Output file specifications
3. **Include the workflow file(s)** (.bonsai files)
4. **Add any configuration files** needed
5. **Test the workflow** with actual hardware before committing
