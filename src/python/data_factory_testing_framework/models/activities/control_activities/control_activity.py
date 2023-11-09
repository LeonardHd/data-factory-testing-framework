from typing import Callable

from data_factory_testing_framework.models.state.pipeline_run_state import PipelineRunState


class ControlActivity:

    @staticmethod
    def patch_generated_models(models):
        models.ControlActivity.evaluate_control_activity_iterations = ControlActivity.evaluate_control_activity_iterations

    def evaluate_control_activity_iterations(self, state: PipelineRunState, evaluate: Callable):
        return []