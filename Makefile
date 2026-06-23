# Makefile for sdk-codegen compatibility
# The upstream stripe-dotnet repo runs `make codegen-format` after code generation.
# We skip formatting for custom SDK generation.

.PHONY: codegen-format
codegen-format:
	@echo "Skipping codegen-format (custom SDK base)"
