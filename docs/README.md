# acquisition

This repository provides a toolkit of Bonsai-based workflows and operators for hardware control and data acquisition in the `ucl-open` ecosystem. 

---

## Core repositories

`acquisition` is part of a small set of tightly related core repositories:

- **[ucl-open-rigs](https://github.com/ucl-open/ucl-open-rigs)** – shared, versioned descriptions of experimental rigs
- **[rig-template](https://github.com/ucl-open/rig-template)** – the primary entry point for creating new experiment repositories, using Copier
- **acquisition** – Bonsai workflows and operators for hardware control and data collection (this repository)

Most users will not be working and making commits directly to `acquisition`, instead using it as a Bonsai package, published to [Nuget](https://nuget.org) and installed through the Bosnai package manager. Experimental repositories built using the rig-template come with this dependency baked-in.

---

## Design principles

This repository is guided by a small set of design principles:

- Keep acquisition logic generic and reusable
- Bind workflows to rig contracts, not to specific logic
- Separate hardware description from experimental logic
- Prefer composition of small operators over monolithic workflows

---

## What this repository is

`acquisition` provides:

- Reusable Bonsai workflows for common acquisition patterns
- Operators and abstractions for interfacing with hardware

The repository focuses on *how data is acquired*, not on *what an experiment does with that data*.

---

## What this repository is not

`acquisition` is **not**:

- An experiment repository
- A place for task logic or behavioural protocols
- A lab-specific wiring configuration

Rig-specific details belong in `ucl-open-rigs`; experiment-specific logic belongs in experiment repositories.

---

## Relationship to ucl-open-rigs

`acquisition` is designed to work *directly* with [ucl-open-rigs](https://github.com/ucl-open/ucl-open-rigs).

In particular:

- Workflows assume the rig contracts defined in `ucl-open-rigs`
- Device names, channels, and capabilities are resolved via rig definitions
- Changes to hardware or wiring are handled by updating the rig, not by editing workflows

This keeps acquisition code portable across rigs that satisfy the same contract.

---

## How it fits into experiments

Typical usage looks like this:

1. An experiment repository is created from the [rig-template](https://github.com/ucl-open/rig-template)
2. The template pulls in `acquisition` and `ucl-open-rigs`, with versions locked to each other
3. A rig definition is selected or extended
4. Acquisition workflows are configured using ucl-open/acquisition operators on that rig
5. Experiments trigger and coordinate acquisition, but do not reimplement it

Experiments depend on acquisition *behaviour*, not on device-level details.

---

## Versioning and dependency locking

Typical practice is:

- Experiment repositories lock specific versions (tags or commits) against **ucl-open-rigs**
- Updates are pulled deliberately and tested against known rigs
- Breaking changes require an explicit version bump

This ensures acquisition behaviour remains reproducible and consistent with historical data.

---

## Using this repository

You typically work directly with this repository only when:

- Adding new reusable acquisition workflows or operators
- Extending support for new classes of hardware
- Improving shared abstractions used across labs

If you find yourself copying workflows into experiment repositories, there is usually something wrong.