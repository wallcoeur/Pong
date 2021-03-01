/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Nickname : Eldersys                                        |
|    Date of creation : 01/03/2021                              |
|---------------------------------------------------------------*/

using Pong.Player.Kinematics;
using UnityEngine;

namespace Pong.Player.InputControllers
{
    [RequireComponent(typeof(SecondPlayerKinematic))]
    public class SecondPlayerController : ControllerChecker
    {
    }
}