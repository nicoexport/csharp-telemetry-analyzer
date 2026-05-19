# csharp-telemetry-analyzer
Small C# telemetry analysis console application using LINQ for filtering, aggregation and statistics processing consisting of a log generator and a log analyzer.

The project was built as a learning exercise focused on:

- Structured software design
- File I/O
- Parsing structured log data
- Enum parsing and validation
- Separating responsibilities across projects
- Basic telemetry processing concepts

---

## Project Structure

```text
TelemetryPipeline/
│
├── src/
│   ├── TelemetryGenerator/   # Generates telemetry log files
│   ├── TelemetryAnalyzer/    # Parses and analyzes telemetry logs
│   └── TelemetryShared/      # Shared models and enums
│
└── README.md
```

---

## How It Works

1. The generator creates a telemetry log file
2. The analyzer reads and parses the generated file
3. Parsed telemetry events are processed and analyzed

---

## Requirements

- .NET 10.0 SDK

Verify installation:

```bash
dotnet --version
```

---

## Running the Project

Run the generator first:

```bash
dotnet run --project src/TelemetryGenerator
```

Then run the analyzer:

```bash
dotnet run --project src/TelemetryAnalyzer
```

---

## Log Format

Each telemetry event is written in the following format:

```text
2026-05-18T17:54:19.1248561Z|Warning|GPU|DESKTOP-01|GPU device lost
```

### Fields

| Field | Description |
|---|---|
| Timestamp | ISO 8601 UTC timestamp |
| Severity | Event severity |
| Category | Telemetry category/component |
| Machine | Source machine name |
| Message | Event description |

---

## Example Severities

- Information
- Warning
- Error

---

## Current Features

- Telemetry event generation
- Structured log parsing
- Enum parsing using `Enum.TryParse`
- Shared contracts via a shared project

---

## Future Improvements

- Command-line arguments
- Configurable input/output paths
- Real-time streaming
- Structured error reporting
- Filtering and aggregation
- JSON-based telemetry format

---

## Purpose

This repository is primarily intended as a small educational project for practicing clean project structure and backend-oriented C# development concepts.