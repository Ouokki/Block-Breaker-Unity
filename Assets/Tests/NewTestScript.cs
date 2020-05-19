using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System;

namespace Tests
{
    public class NewTestScript
    {
        
        // A Test behaves as an ordinary method
        [Test]
        public void TestScoreEarlyGame()
        {
            //var gamesession= new GameObject().AddComponent<GameSession>();
            // Use the Assert class to test conditions
            
            int score = GameSession.currentScore;
            Debug.Log(score);

            Assert.AreEqual(0, score);
        }
       

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
    }

