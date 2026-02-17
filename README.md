# Dotnet WebApp Demo

A production-style two-tier ASP.NET Core application designed to serve as the workload for a cloud-native GitOps platform.

This repository contains a real-world structured solution composed of:

- **WebApp** – ASP.NET Core MVC (UI / edge tier)
- **WebApi** – ASP.NET Core Web API (business logic tier)
- **PostgreSQL (RDS-ready)** – Persistent storage via EF Core

The application is intentionally designed to be deployed on Kubernetes (EKS), managed via GitOps (Argo CD), secured with Istio mTLS, and configured using environment-based settings and sealed secrets.

---

## Architecture Overview

Internet  
→ WebApp (MVC UI)  
→ WebApi (REST API)  
→ PostgreSQL (RDS)

Key architectural principles:

- Clear separation of concerns between UI and API tiers
- Full CRUD API (Tasks domain)
- EF Core with migrations
- Environment-driven configuration (12-factor compliant)
- Health and readiness endpoints for Kubernetes probes
- Containerized using multi-stage Docker builds

---

## Domain Model

The application implements a simple but realistic **Task Management system**.

Each Task contains:
- `Id` (Guid)
- `Title`
- `Status` (Todo, Doing, Done)
- `CreatedAtUtc`
- `UpdatedAtUtc`

The goal is not business complexity, but operational realism.

---

## Platform-Ready Features

The application includes endpoints and behaviors specifically designed for cloud-native deployment:

- `/healthz` – process health
- `/readyz` – database connectivity check
- `/version` – deployment version identifier
- Environment-variable-based configuration
- No hardcoded secrets

This allows integration with:
- Kubernetes liveness/readiness probes
- Canary rollouts
- GitOps workflows
- Sealed Secrets
- Istio traffic management

---

## Why This Project Exists

This repository is not just a CRUD demo.

It serves as the reference workload for a broader cloud-native platform that demonstrates:

- GitOps deployment practices
- Progressive delivery
- Service-to-service security
- Secrets management
- Infrastructure reproducibility

It is intentionally structured to reflect production-ready development standards.
