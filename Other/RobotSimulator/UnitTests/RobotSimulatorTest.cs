// This file was auto-generated based on version 3.1.0 of the canonical data.

using Xunit;

namespace RobotSimulatorProject.UnitTests
{
    public class RobotSimulatorTest
    {
        [Fact]
        public void A_robot_is_created_with_a_position_and_a_direction_robots_are_created_with_a_position_and_direction()
        {
            var sut = new RobotSimulator(Direction.North, new Coordinates(0, 0));
            Assert.Equal(Direction.North, sut.CurrentDirection);
            Assert.Equal(0, sut.CurrentCoordinates.X);
            Assert.Equal(0, sut.CurrentCoordinates.Y);
        }

        [Fact]
        public void A_robot_is_created_with_a_position_and_a_direction_negative_positions_are_allowed()
        {
            var sut = new RobotSimulator(Direction.South, new Coordinates(-1, -1));
            Assert.Equal(Direction.South, sut.CurrentDirection);
            Assert.Equal(-1, sut.CurrentCoordinates.X);
            Assert.Equal(-1, sut.CurrentCoordinates.Y);
        }

        [Fact]
        public void Rotates_the_robots_direction_90_degrees_clockwise_changes_the_direction_from_north_to_east()
        {
            var sut = new RobotSimulator(Direction.North, new Coordinates(0, 0));
            sut.Simulate("R");
            Assert.Equal(Direction.East, sut.CurrentDirection);
            Assert.Equal(0, sut.CurrentCoordinates.X);
            Assert.Equal(0, sut.CurrentCoordinates.Y);
        }

        [Fact]
        public void Rotates_the_robots_direction_90_degrees_clockwise_changes_the_direction_from_east_to_south()
        {
            var sut = new RobotSimulator(Direction.East, new Coordinates(0, 0));
            sut.Simulate("R");
            Assert.Equal(Direction.South, sut.CurrentDirection);
            Assert.Equal(0, sut.CurrentCoordinates.X);
            Assert.Equal(0, sut.CurrentCoordinates.Y);
        }

        [Fact]
        public void Rotates_the_robots_direction_90_degrees_clockwise_changes_the_direction_from_south_to_west()
        {
            var sut = new RobotSimulator(Direction.South, new Coordinates(0, 0));
            sut.Simulate("R");
            Assert.Equal(Direction.West, sut.CurrentDirection);
            Assert.Equal(0, sut.CurrentCoordinates.X);
            Assert.Equal(0, sut.CurrentCoordinates.Y);
        }

        [Fact]
        public void Rotates_the_robots_direction_90_degrees_clockwise_changes_the_direction_from_west_to_north()
        {
            var sut = new RobotSimulator(Direction.West, new Coordinates(0, 0));
            sut.Simulate("R");
            Assert.Equal(Direction.North, sut.CurrentDirection);
            Assert.Equal(0, sut.CurrentCoordinates.X);
            Assert.Equal(0, sut.CurrentCoordinates.Y);
        }

        [Fact]
        public void Rotates_the_robots_direction_90_degrees_counter_clockwise_changes_the_direction_from_north_to_west()
        {
            var sut = new RobotSimulator(Direction.North, new Coordinates(0, 0));
            sut.Simulate("L");
            Assert.Equal(Direction.West, sut.CurrentDirection);
            Assert.Equal(0, sut.CurrentCoordinates.X);
            Assert.Equal(0, sut.CurrentCoordinates.Y);
        }

        [Fact]
        public void Rotates_the_robots_direction_90_degrees_counter_clockwise_changes_the_direction_from_west_to_south()
        {
            var sut = new RobotSimulator(Direction.West, new Coordinates(0, 0));
            sut.Simulate("L");
            Assert.Equal(Direction.South, sut.CurrentDirection);
            Assert.Equal(0, sut.CurrentCoordinates.X);
            Assert.Equal(0, sut.CurrentCoordinates.Y);
        }

        [Fact]
        public void Rotates_the_robots_direction_90_degrees_counter_clockwise_changes_the_direction_from_south_to_east()
        {
            var sut = new RobotSimulator(Direction.South, new Coordinates(0, 0));
            sut.Simulate("L");
            Assert.Equal(Direction.East, sut.CurrentDirection);
            Assert.Equal(0, sut.CurrentCoordinates.X);
            Assert.Equal(0, sut.CurrentCoordinates.Y);
        }

        [Fact]
        public void Rotates_the_robots_direction_90_degrees_counter_clockwise_changes_the_direction_from_east_to_north()
        {
            var sut = new RobotSimulator(Direction.East, new Coordinates(0, 0));
            sut.Simulate("L");
            Assert.Equal(Direction.North, sut.CurrentDirection);
            Assert.Equal(0, sut.CurrentCoordinates.X);
            Assert.Equal(0, sut.CurrentCoordinates.Y);
        }

        [Fact]
        public void Moves_the_robot_forward_1_space_in_the_direction_it_is_pointing_increases_the_y_coordinate_one_when_facing_north()
        {
            var sut = new RobotSimulator(Direction.North, new Coordinates(0, 0));
            sut.Simulate("A");
            Assert.Equal(Direction.North, sut.CurrentDirection);
            Assert.Equal(0, sut.CurrentCoordinates.X);
            Assert.Equal(1, sut.CurrentCoordinates.Y);
        }

        [Fact]
        public void Moves_the_robot_forward_1_space_in_the_direction_it_is_pointing_decreases_the_y_coordinate_by_one_when_facing_south()
        {
            var sut = new RobotSimulator(Direction.South, new Coordinates(0, 0));
            sut.Simulate("A");
            Assert.Equal(Direction.South, sut.CurrentDirection);
            Assert.Equal(0, sut.CurrentCoordinates.X);
            Assert.Equal(-1, sut.CurrentCoordinates.Y);
        }

        [Fact]
        public void Moves_the_robot_forward_1_space_in_the_direction_it_is_pointing_increases_the_x_coordinate_by_one_when_facing_east()
        {
            var sut = new RobotSimulator(Direction.East, new Coordinates(0, 0));
            sut.Simulate("A");
            Assert.Equal(Direction.East, sut.CurrentDirection);
            Assert.Equal(1, sut.CurrentCoordinates.X);
            Assert.Equal(0, sut.CurrentCoordinates.Y);
        }

        [Fact]
        public void Moves_the_robot_forward_1_space_in_the_direction_it_is_pointing_decreases_the_x_coordinate_by_one_when_facing_west()
        {
            var sut = new RobotSimulator(Direction.West, new Coordinates(0, 0));
            sut.Simulate("A");
            Assert.Equal(Direction.West, sut.CurrentDirection);
            Assert.Equal(-1, sut.CurrentCoordinates.X);
            Assert.Equal(0, sut.CurrentCoordinates.Y);
        }

        [Fact]
        public void Where_r_turn_right_l_turn_left_and_a_advance_the_robot_can_follow_a_series_of_instructions_and_end_up_with_the_correct_position_and_direction_instructions_to_move_east_and_north_from_readme()
        {
            var sut = new RobotSimulator(Direction.North, new Coordinates(7, 3));
            sut.Simulate("RAALAL");
            Assert.Equal(Direction.West, sut.CurrentDirection);
            Assert.Equal(9, sut.CurrentCoordinates.X);
            Assert.Equal(4, sut.CurrentCoordinates.Y);
        }

        [Fact]
        public void Where_r_turn_right_l_turn_left_and_a_advance_the_robot_can_follow_a_series_of_instructions_and_end_up_with_the_correct_position_and_direction_instructions_to_move_west_and_north()
        {
            var sut = new RobotSimulator(Direction.North, new Coordinates(0, 0));
            sut.Simulate("LAAARALA");
            Assert.Equal(Direction.West, sut.CurrentDirection);
            Assert.Equal(-4, sut.CurrentCoordinates.X);
            Assert.Equal(1, sut.CurrentCoordinates.Y);
        }

        [Fact]
        public void Where_r_turn_right_l_turn_left_and_a_advance_the_robot_can_follow_a_series_of_instructions_and_end_up_with_the_correct_position_and_direction_instructions_to_move_west_and_south()
        {
            var sut = new RobotSimulator(Direction.East, new Coordinates(2, -7));
            sut.Simulate("RRAAAAALA");
            Assert.Equal(Direction.South, sut.CurrentDirection);
            Assert.Equal(-3, sut.CurrentCoordinates.X);
            Assert.Equal(-8, sut.CurrentCoordinates.Y);
        }

        [Fact]
        public void Where_r_turn_right_l_turn_left_and_a_advance_the_robot_can_follow_a_series_of_instructions_and_end_up_with_the_correct_position_and_direction_instructions_to_move_east_and_north()
        {
            var sut = new RobotSimulator(Direction.South, new Coordinates(8, 4));
            sut.Simulate("LAAARRRALLLL");
            Assert.Equal(Direction.North, sut.CurrentDirection);
            Assert.Equal(11, sut.CurrentCoordinates.X);
            Assert.Equal(5, sut.CurrentCoordinates.Y);
        }
    }
}