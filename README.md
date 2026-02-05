# acquisition

This repository provides a toolkit of **Bonsai-based workflows and operators for hardware control and data acquisition** used in the `ucl-open` ecosystem.

Its purpose is to provide a common acquisition layer that sits between **rig definitions** and **experiment repositories**, turning declarative descriptions of hardware into reproducible, executable acquisition pipelines.

---

## Core repositories

`acquisition` is part of a small set of tightly related core repositories:

- **[ucl-open-rigs](https://github.com/ucl-open/ucl-open-rigs)** – shared, versioned descriptions of experimental rigs
- **[rig-template](https://github.com/ucl-open/rig-template)** – the primary entry point for creating new experiment repositories, using Copier
- **acquisition** – Bonsai workflows and operators for hardware control and data acquisition (this repository)

Each of these repositories is developed in tandem and is dependent on the others. As development is ongoing, published versions of each are intended to be locked to one another; for example, `v0.1.0` of `acquisition` is compatible with `v0.1.0` of `ucl-open-rigs` and `rig-template`.

In general, lab members and experimentalists will not work directly on this repository. Instead, `acquisition` is published as a Bonsai package (via NuGet) and consumed automatically by experiment repositories created using the `rig-template`.

## What this repository is

`acquisition` provides:

- A **catalogue of reusable Bonsai workflows** for common acquisition patterns
- **Operators and abstractions** for interfacing with experimental hardware
- A **stable acquisition layer** that experiments can rely on for data collection

The repository focuses on *how data is acquired*, not on *what an experiment does with that data*.

---

## What this repository is not

`acquisition` is **not**:

- An experiment repository
- A place for task logic or behavioural protocols
- A repository of rig or wiring descriptions

Experiment-specific logic belongs in experiment repositories.

---

## Repository structure (conceptual)

While details may evolve, the repository contains:

- **Reusable workflows** – common acquisition patterns composed from operators
- **Operators** – low-level abstractions over hardware or data streams
- **Examples** – minimal Bonsai workflows demonstrating intended usage

The emphasis is on *composition*: complex acquisition behaviour is built from small, reusable operators rather than monolithic workflows.

---

## Using this repository

In most cases, you will **not interact with this repository directly**.

The most common usage is **automatic**, via:

- An experiment repository created from the [rig-template](https://github.com/ucl-open/rig-template)
- The template’s dependency configuration, which pulls in `acquisition`
- Integration with the [ucl-open-rigs](https://github.com/ucl-open/ucl-open-rigs) repository

Acquisition workflows are added as a dependency, version-pinned by default, and available immediately within Bonsai without manual installation.

In general, lab members and experimentalists will encounter `acquisition` only indirectly via the template and acquisition stack, rather than by cloning and working with this repository directly.

You typically work directly with this repository only when adding reusable workflows or operators, extending support for new hardware, or improving shared abstractions.

If you find yourself copying workflows out of this repository, you are most likely doing something outside the intended framework.

---

## Relationship to ucl-open-rigs

`acquisition` is designed to work *directly* with [ucl-open-rigs](https://github.com/ucl-open/ucl-open-rigs).

In particular:

- Acquisition workflows assume the **rig contracts** defined in `ucl-open-rigs`
- Device names, channels, and capabilities are resolved via rig definitions
- Changes to physical hardware are handled by updating the rig, not by editing workflows

This keeps acquisition code portable across rigs.

---

## How it fits into experiments

Typical usage looks like this:

1. An experiment repository is created from the [rig-template](https://github.com/ucl-open/rig-template)
2. The template pulls in `acquisition` and `ucl-open-rigs`, with versions locked to each other
3. A rig definition is extended from the template
4. Acquisition workflows are built in Bonsai using `acquisition` operators
5. Experiments trigger and coordinate acquisition, but do not reimplement it

---

## Versioning and dependency locking

`acquisition` is versioned and intended to be **locked by downstream repositories**.

Typical practice is:

- Experiment repositories pin specific versions (tags or commits) of `acquisition`
- Versions are kept in sync with compatible versions of `ucl-open-rigs`
- Updates are pulled deliberately and tested against known rigs
- Breaking changes require an explicit version bump

This ensures acquisition behaviour remains reproducible over time and consistent with historical data.