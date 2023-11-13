import pytest

from data_factory_testing_framework.exceptions.variable_being_evaluated_does_not_exist_error import \
    VariableBeingEvaluatedDoesNotExistError
from data_factory_testing_framework.generated.models import SetVariableActivity, DataFactoryElement, \
    VariableSpecification
from data_factory_testing_framework.models.base.pipeline_run_variable import PipelineRunVariable
from data_factory_testing_framework.models.state.pipeline_run_state import PipelineRunState
from data_factory_testing_framework.models.test_framework import TestFramework


def test_when_string_variable_evaluated_then_state_variable_should_be_set():
    # Arrange
    test_framework = TestFramework()
    variable_name = "TestVariable"
    set_variable_activity = SetVariableActivity(
        name="SetVariableActivity",
        variable_name=variable_name,
        value=DataFactoryElement("TestValue")
    )
    state = PipelineRunState(variable_specifications={
        variable_name: VariableSpecification(type="String", default_value="")
    })

    # Act
    set_variable_activity.evaluate(state)

    # Assert
    variable = state.get_variable_by_name(variable_name)
    assert variable.value == "TestValue"


def test_when_unknown_variable_evaluated_then_should_raise_exception():
    # Arrange
    test_framework = TestFramework()
    variable_name = "TestVariable"
    set_variable_activity = SetVariableActivity(
        name="SetVariableActivity",
        variable_name=variable_name,
        value=DataFactoryElement("TestValue")
    )
    state = PipelineRunState()

    # Act
    with pytest.raises(VariableBeingEvaluatedDoesNotExistError) as exception_info:
        set_variable_activity.evaluate(state)

    # Assert
    assert exception_info.value.args[0] == "Variable being evaluated does not exist: TestVariable"