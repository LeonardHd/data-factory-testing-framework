import shutil
import subprocess
from pathlib import Path

from setuptools import Command, setup
from setuptools.command.build import build


class CustomCommand(Command):
    build_lib = "dotnet_build"

    def initialize_options(self) -> None:
        self.bdist_dir = None

    def finalize_options(self) -> None:
        self.bdist_dir = Path(self.get_finalized_command("bdist_wheel").bdist_dir)

    def run(self) -> None:
        if self.bdist_dir:
            self.bdist_dir.mkdir(parents=True, exist_ok=True)
            dotnet_path = shutil.which("dotnet")

            if dotnet_path is None:
                raise Exception("dotnet not found")
            subprocess.check_call([dotnet_path, "build", "-c", "Release", "-o", self.build_lib])
            # copy build files to the bdist_dir
            shutil.copytree(
                self.build_lib,
                self.bdist_dir / "data_factory_testing_framework" / "DataFactoryTestingFrameworkEvaluator",
                dirs_exist_ok=True,
            )


class CustomBuild(build):
    sub_commands = [("build_custom", None)] + build.sub_commands


try:
    root = Path(__file__).parent
    with open(root / "VERSION") as version_file:
        version = version_file.read().strip()
except FileNotFoundError:
    # Set a default version (for local builds)
    version = "0.0.0.dev0"

setup(cmdclass={"build": CustomBuild, "build_custom": CustomCommand}, version=version)
